namespace tipaKursach
{
    partial class AuthorizationForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.regPanel = new System.Windows.Forms.Panel();
            this.toRegistrationButton = new System.Windows.Forms.Button();
            this.recToRegistration = new System.Windows.Forms.Label();
            this.toRegLabel = new System.Windows.Forms.Label();
            this.authPanel = new System.Windows.Forms.Panel();
            this.authoriztionButton = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.mainAuthLabel = new System.Windows.Forms.Label();
            this.regPanel.SuspendLayout();
            this.authPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // regPanel
            // 
            this.regPanel.Controls.Add(this.toRegistrationButton);
            this.regPanel.Controls.Add(this.recToRegistration);
            this.regPanel.Controls.Add(this.toRegLabel);
            this.regPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.regPanel.Location = new System.Drawing.Point(0, 0);
            this.regPanel.Name = "regPanel";
            this.regPanel.Size = new System.Drawing.Size(320, 314);
            this.regPanel.TabIndex = 0;
            // 
            // toRegistrationButton
            // 
            this.toRegistrationButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toRegistrationButton.Location = new System.Drawing.Point(85, 244);
            this.toRegistrationButton.Name = "toRegistrationButton";
            this.toRegistrationButton.Size = new System.Drawing.Size(141, 41);
            this.toRegistrationButton.TabIndex = 4;
            this.toRegistrationButton.Text = "Регистрация";
            this.toRegistrationButton.UseVisualStyleBackColor = true;
            this.toRegistrationButton.Click += new System.EventHandler(this.toRegistrationButton_Click);
            // 
            // recToRegistration
            // 
            this.recToRegistration.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.recToRegistration.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.recToRegistration.Location = new System.Drawing.Point(45, 131);
            this.recToRegistration.Name = "recToRegistration";
            this.recToRegistration.Size = new System.Drawing.Size(233, 46);
            this.recToRegistration.TabIndex = 5;
            this.recToRegistration.Text = "Присоединяйтесь к нам, подходите к делам ответственно и с расстановкой, вместе с " +
    "нами\r\n\r\n";
            // 
            // toRegLabel
            // 
            this.toRegLabel.AutoSize = true;
            this.toRegLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toRegLabel.Location = new System.Drawing.Point(42, 61);
            this.toRegLabel.Name = "toRegLabel";
            this.toRegLabel.Size = new System.Drawing.Size(236, 32);
            this.toRegLabel.TabIndex = 4;
            this.toRegLabel.Text = "Приветствуем вас!";
            // 
            // authPanel
            // 
            this.authPanel.Controls.Add(this.authoriztionButton);
            this.authPanel.Controls.Add(this.passwordTextBox);
            this.authPanel.Controls.Add(this.loginTextBox);
            this.authPanel.Controls.Add(this.mainAuthLabel);
            this.authPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.authPanel.Location = new System.Drawing.Point(321, 0);
            this.authPanel.Name = "authPanel";
            this.authPanel.Size = new System.Drawing.Size(320, 314);
            this.authPanel.TabIndex = 1;
            // 
            // authoriztionButton
            // 
            this.authoriztionButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authoriztionButton.Location = new System.Drawing.Point(84, 244);
            this.authoriztionButton.Name = "authoriztionButton";
            this.authoriztionButton.Size = new System.Drawing.Size(141, 41);
            this.authoriztionButton.TabIndex = 6;
            this.authoriztionButton.Text = "Авторизироваться";
            this.authoriztionButton.UseVisualStyleBackColor = true;
            this.authoriztionButton.Click += new System.EventHandler(this.authoriztionButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(65, 184);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(180, 20);
            this.passwordTextBox.TabIndex = 2;
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(65, 144);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(180, 20);
            this.loginTextBox.TabIndex = 1;
            // 
            // mainAuthLabel
            // 
            this.mainAuthLabel.AutoSize = true;
            this.mainAuthLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainAuthLabel.Location = new System.Drawing.Point(37, 61);
            this.mainAuthLabel.Name = "mainAuthLabel";
            this.mainAuthLabel.Size = new System.Drawing.Size(232, 32);
            this.mainAuthLabel.TabIndex = 0;
            this.mainAuthLabel.Text = "Войдите в аккаунт";
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 314);
            this.Controls.Add(this.authPanel);
            this.Controls.Add(this.regPanel);
            this.Name = "AuthorizationForm";
            this.Text = " ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AuthorizationForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.regPanel.ResumeLayout(false);
            this.regPanel.PerformLayout();
            this.authPanel.ResumeLayout(false);
            this.authPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel regPanel;
        private System.Windows.Forms.Panel authPanel;
        private System.Windows.Forms.Label mainAuthLabel;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label toRegLabel;
        private System.Windows.Forms.Label recToRegistration;
        private System.Windows.Forms.Button toRegistrationButton;
        private System.Windows.Forms.Button authoriztionButton;
    }
}

