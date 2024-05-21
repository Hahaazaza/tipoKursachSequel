namespace tipaKursach
{
    partial class RegistrationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.regPanel = new System.Windows.Forms.Panel();
            this.toAuthButton = new System.Windows.Forms.Button();
            this.recToRegistration = new System.Windows.Forms.Label();
            this.toRegLabel = new System.Windows.Forms.Label();
            this.authPanel = new System.Windows.Forms.Panel();
            this.registrationButton = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.mainAuthLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.regPanel.SuspendLayout();
            this.authPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // regPanel
            // 
            this.regPanel.Controls.Add(this.toAuthButton);
            this.regPanel.Controls.Add(this.recToRegistration);
            this.regPanel.Controls.Add(this.toRegLabel);
            this.regPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.regPanel.Location = new System.Drawing.Point(0, 0);
            this.regPanel.Name = "regPanel";
            this.regPanel.Size = new System.Drawing.Size(320, 314);
            this.regPanel.TabIndex = 2;
            // 
            // toAuthButton
            // 
            this.toAuthButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toAuthButton.Location = new System.Drawing.Point(85, 244);
            this.toAuthButton.Name = "toAuthButton";
            this.toAuthButton.Size = new System.Drawing.Size(141, 41);
            this.toAuthButton.TabIndex = 4;
            this.toAuthButton.Text = "Авторизация";
            this.toAuthButton.UseVisualStyleBackColor = true;
            this.toAuthButton.Click += new System.EventHandler(this.toAuthButton_Click);
            // 
            // recToRegistration
            // 
            this.recToRegistration.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.recToRegistration.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.recToRegistration.Location = new System.Drawing.Point(73, 146);
            this.recToRegistration.Name = "recToRegistration";
            this.recToRegistration.Size = new System.Drawing.Size(164, 46);
            this.recToRegistration.TabIndex = 5;
            this.recToRegistration.Text = "Настало время вернутся к поставленным задачам";
            // 
            // toRegLabel
            // 
            this.toRegLabel.AutoSize = true;
            this.toRegLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toRegLabel.Location = new System.Drawing.Point(42, 61);
            this.toRegLabel.Name = "toRegLabel";
            this.toRegLabel.Size = new System.Drawing.Size(224, 32);
            this.toRegLabel.TabIndex = 4;
            this.toRegLabel.Text = "С возвращением!";
            // 
            // authPanel
            // 
            this.authPanel.Controls.Add(this.nameTextBox);
            this.authPanel.Controls.Add(this.registrationButton);
            this.authPanel.Controls.Add(this.passwordTextBox);
            this.authPanel.Controls.Add(this.loginTextBox);
            this.authPanel.Controls.Add(this.mainAuthLabel);
            this.authPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.authPanel.Location = new System.Drawing.Point(321, 0);
            this.authPanel.Name = "authPanel";
            this.authPanel.Size = new System.Drawing.Size(320, 314);
            this.authPanel.TabIndex = 3;
            // 
            // registrationButton
            // 
            this.registrationButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrationButton.Location = new System.Drawing.Point(84, 244);
            this.registrationButton.Name = "registrationButton";
            this.registrationButton.Size = new System.Drawing.Size(146, 41);
            this.registrationButton.TabIndex = 6;
            this.registrationButton.Text = "Зарегистрироваться";
            this.registrationButton.UseVisualStyleBackColor = true;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(65, 200);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(180, 20);
            this.passwordTextBox.TabIndex = 2;
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(65, 159);
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
            this.mainAuthLabel.Size = new System.Drawing.Size(221, 32);
            this.mainAuthLabel.TabIndex = 0;
            this.mainAuthLabel.Text = "Создайте аккаунт";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(65, 117);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(180, 20);
            this.nameTextBox.TabIndex = 7;
            this.nameTextBox.Enter += new System.EventHandler(this.nameTextBox_Enter);
            this.nameTextBox.Leave += new System.EventHandler(this.nameTextBox_Leave);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 314);
            this.Controls.Add(this.regPanel);
            this.Controls.Add(this.authPanel);
            this.Name = "RegistrationForm";
            this.Text = "Регистрация";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegistrationForm_FormClosing);
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            this.regPanel.ResumeLayout(false);
            this.regPanel.PerformLayout();
            this.authPanel.ResumeLayout(false);
            this.authPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel regPanel;
        private System.Windows.Forms.Button toAuthButton;
        private System.Windows.Forms.Label recToRegistration;
        private System.Windows.Forms.Label toRegLabel;
        private System.Windows.Forms.Panel authPanel;
        private System.Windows.Forms.Button registrationButton;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.Label mainAuthLabel;
        private System.Windows.Forms.TextBox nameTextBox;
    }
}