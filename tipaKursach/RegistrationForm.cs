using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tipaKursach
{
    public partial class RegistrationForm : Form
    {
        private readonly AuthorizationForm _authorizationForm;
        public RegistrationForm(AuthorizationForm authorizationForm)
        {
            InitializeComponent();
            regPanel.BackColor = Color.FromArgb(224, 233, 235);
            authPanel.BackColor = Color.FromArgb(245, 250, 250);
            // Устанавливаем текст "Логин" и "Пароль" в loginTextBox и passwordTextBox соответственно
            nameTextBox.Text = "Имя пользователя";
            loginTextBox.Text = "Логин";
            passwordTextBox.Text = "Пароль";

            // Устанавливаем цвет текста в серый
            nameTextBox.ForeColor = Color.Gray;
            loginTextBox.ForeColor = Color.Gray;
            passwordTextBox.ForeColor = Color.Gray;

            // Добавляем события для очистки текста при вводе
            nameTextBox.Enter += LoginTextBox_Enter;
            loginTextBox.Enter += LoginTextBox_Enter;
            passwordTextBox.Enter += PasswordTextBox_Enter;

            // Добавляем события для восстановления текста при выходе
            nameTextBox.Leave += LoginTextBox_Leave;
            loginTextBox.Leave += LoginTextBox_Leave;
            passwordTextBox.Leave += PasswordTextBox_Leave;

            toAuthButton.BackColor = Color.Transparent;
            toAuthButton.FlatAppearance.BorderColor = Color.FromArgb(59, 137, 209);
            toAuthButton.FlatAppearance.BorderSize = 1;
            toAuthButton.FlatStyle = FlatStyle.Flat;

            registrationButton.BackColor = Color.Transparent;
            registrationButton.FlatAppearance.BorderColor = Color.FromArgb(59, 137, 209);
            registrationButton.FlatAppearance.BorderSize = 1;
            registrationButton.FlatStyle = FlatStyle.Flat;
            _authorizationForm = authorizationForm;
        }

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

        private void nameTextBox_Enter(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "Имя пользователя")
            {
                nameTextBox.Text = "";
                nameTextBox.ForeColor = Color.Black;
            }
        }

        private void nameTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameTextBox.Text))
            {
                nameTextBox.Text = "Имя пользователя";
                nameTextBox.ForeColor = Color.Gray;
            }
        }

        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void toAuthButton_Click(object sender, EventArgs e)
        {
            _authorizationForm.Show();
            this.Hide();
        }
        private void RegistrationForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close(); // закрываем вторую форму, при этом первая форма будет показана в обработчике события FormClosed
            }
        }

        private void RegistrationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
            Application.Exit();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            AddTextBoxEffects(loginTextBox);
            AddTextBoxEffects(passwordTextBox);
        }
    }
}
