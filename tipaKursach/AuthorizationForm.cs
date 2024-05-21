using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace tipaKursach
{
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
            regPanel.BackColor = Color.FromArgb(224, 233, 235);
            authPanel.BackColor = Color.FromArgb(245, 250, 250);

            // Добавляем внутренние тени и закругленную форму к loginTextBox и passwordTextBox
            AddTextBoxEffects(loginTextBox);
            AddTextBoxEffects(passwordTextBox);

            // Устанавливаем текст "Логин" и "Пароль" в loginTextBox и passwordTextBox соответственно
            loginTextBox.Text = "Логин";
            passwordTextBox.Text = "Пароль";

            // Устанавливаем цвет текста в серый
            loginTextBox.ForeColor = Color.Gray;
            passwordTextBox.ForeColor = Color.Gray;

            // Добавляем события для очистки текста при вводе
            loginTextBox.Enter += LoginTextBox_Enter;
            passwordTextBox.Enter += PasswordTextBox_Enter;

            // Добавляем события для восстановления текста при выходе
            loginTextBox.Leave += LoginTextBox_Leave;
            passwordTextBox.Leave += PasswordTextBox_Leave;

            toRegistrationButton.BackColor = Color.Transparent;
            toRegistrationButton.FlatAppearance.BorderColor = Color.FromArgb(59, 137, 209);
            toRegistrationButton.FlatAppearance.BorderSize = 1;
            toRegistrationButton.FlatStyle = FlatStyle.Flat;

            authoriztionButton.BackColor = Color.Transparent;
            authoriztionButton.FlatAppearance.BorderColor = Color.FromArgb(59, 137, 209);
            authoriztionButton.FlatAppearance.BorderSize = 1;
            authoriztionButton.FlatStyle = FlatStyle.Flat;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AddTextBoxEffects(loginTextBox);
            AddTextBoxEffects(passwordTextBox);
        }

        string connectionString = "Server=localhost;Port=5432;Database=postgres; User Id = postgres; Password=P@ssw0rd;";

        private void AddTextBoxEffects(TextBox textBox)
        {
            textBox.Enter += TextBox_Enter;
            textBox.Leave += TextBox_Leave;

            // Изменяем цвет фона на RGB(230, 230, 230)
            textBox.BackColor = Color.FromArgb(230, 230, 230);

        }

        // Метод для создания закругленного прямоугольника
        private GraphicsPath GetRoundedRect(Rectangle rect, int radius)
        {
            int diameter = radius * 2;
            Size size = new Size(diameter, diameter);
            Rectangle arcRect = new Rectangle(rect.Location, size);
            GraphicsPath path = new GraphicsPath();

            if (radius == 0)
            {
                path.AddRectangle(rect);
                return path;
            }

            // Верхний левый угол
            path.AddArc(arcRect, 180, 90);

            // Верхний правый угол
            arcRect.X = rect.Right - diameter;
            path.AddArc(arcRect, 270, 90);

            // Нижний правый угол
            arcRect.Y = rect.Bottom - diameter;
            path.AddArc(arcRect, 0, 90);

            // Нижний левый угол
            arcRect.X = rect.Left;
            path.AddArc(arcRect, 90, 90);

            path.CloseFigure();
            return path;
        }

        // Событие при вводе текста в TextBox
        private void TextBox_Enter(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.BackColor = Color.FromArgb(245, 245, 245);
        }

        // Событие при выходе из TextBox
        private void TextBox_Leave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.BackColor = Color.FromArgb(230, 230, 230);
        }

        // Очистка текста при вводе в loginTextBox
        private void LoginTextBox_Enter(object sender, EventArgs e)
        {
            if (loginTextBox.Text == "Логин")
            {
                loginTextBox.Text = "";
                loginTextBox.ForeColor = Color.Black;
            }
        }

        // Восстановление текста при выходе из loginTextBox
        private void LoginTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(loginTextBox.Text))
            {
                loginTextBox.Text = "Логин";
                loginTextBox.ForeColor = Color.Gray;
            }
        }

        // Очистка текста при вводе в passwordTextBox
        private void PasswordTextBox_Enter(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == "Пароль")
            {
                passwordTextBox.Text = "";
                passwordTextBox.ForeColor = Color.Black;
                passwordTextBox.UseSystemPasswordChar = true;
            }
        }

        // Восстановление текста при выходе из passwordTextBox
        private void PasswordTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(passwordTextBox.Text))
            {
                passwordTextBox.Text = "Пароль";
                passwordTextBox.ForeColor = Color.Gray;
                passwordTextBox.UseSystemPasswordChar = false;
            }
        }

        private void toRegistrationButton_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm(this);
            registrationForm.Show();
            this.Hide();
        }

        private void AuthorizationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
            Application.Exit();
        }

        private void authoriztionButton_Click(object sender, EventArgs e)
        {
            // Получаем введенные данные
            string email = loginTextBox.Text;
            string password = passwordTextBox.Text;

            NpgsqlConnection sqlConnection = new NpgsqlConnection(connectionString);
            sqlConnection.Open();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = sqlConnection;
            command.CommandType = CommandType.Text;

            // Создаем SQL-запрос для выбора пользователя из базы данных по электронной почте
            string sqlQuery = "SELECT * FROM users WHERE email = @email";
            command.CommandText = sqlQuery;

            // Добавляем параметр в SQL-запрос
            command.Parameters.AddWithValue("email", email);

            // Выполняем SQL-запрос и получаем результат
            NpgsqlDataReader dataReader = command.ExecuteReader();

            // Проверяем, найден ли пользователь в базе данных
            if (dataReader.Read())
            {
                // Получаем хешированный пароль из базы данных
                string hashedPassword = dataReader["password"].ToString();

                // Хешируем введенный пароль и сравниваем с хешированным паролем из базы данных
                if (HashPassword(password) == hashedPassword)
                {
                    // Создаем экземпляр формы MainForm и переходим на нее
                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    // Выводим сообщение об ошибке авторизации
                    MessageBox.Show("Неверный пароль", "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Выводим сообщение об ошибке авторизации
                MessageBox.Show("Пользователь с таким email не найден", "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Закрываем подключение к базе данных
            sqlConnection.Close();
        }

        private string HashPassword(string password)
        {
            // Создаем объект для генерации хеша пароля
            using (var sha256 = SHA256.Create())
            {
                // Преобразуем пароль в массив байтов
                var passwordBytes = Encoding.UTF8.GetBytes(password);

                // Генерируем хеш пароля
                var hashBytes = sha256.ComputeHash(passwordBytes);

                // Преобразуем массив байтов в строку
                var hash = BitConverter.ToString(hashBytes).Replace("-", "").ToLower();

                return hash;
            }
        }

    }


}
