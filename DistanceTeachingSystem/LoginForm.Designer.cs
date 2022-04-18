namespace DistanceTeachingSystem
{
    partial class LoginForm
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
            this.LoginTabControl = new System.Windows.Forms.TabControl();
            this.LoginPage = new System.Windows.Forms.TabPage();
            this.labelLoginFailed = new System.Windows.Forms.Label();
            this.labelLoginPassword = new System.Windows.Forms.Label();
            this.labelLoginName = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtBoxLoginPassword = new System.Windows.Forms.TextBox();
            this.txtBoxLoginName = new System.Windows.Forms.TextBox();
            this.RegistrationPage = new System.Windows.Forms.TabPage();
            this.labelRegistrationFailed = new System.Windows.Forms.Label();
            this.labelRepeatPasswordFailed = new System.Windows.Forms.Label();
            this.labelPasswordFailed = new System.Windows.Forms.Label();
            this.labelNameFailed = new System.Windows.Forms.Label();
            this.labelRepeatPassword = new System.Windows.Forms.Label();
            this.labelRegistrationPassword = new System.Windows.Forms.Label();
            this.labelRegistrationName = new System.Windows.Forms.Label();
            this.btnRegistrationAsStudent = new System.Windows.Forms.Button();
            this.btnRegistrationAsTeaher = new System.Windows.Forms.Button();
            this.txtBoxRepeatPassword = new System.Windows.Forms.TextBox();
            this.txtBoxRegistrationPassword = new System.Windows.Forms.TextBox();
            this.txtBoxRegistrationName = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.LoginTabControl.SuspendLayout();
            this.LoginPage.SuspendLayout();
            this.RegistrationPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginTabControl
            // 
            this.LoginTabControl.Controls.Add(this.LoginPage);
            this.LoginTabControl.Controls.Add(this.RegistrationPage);
            this.LoginTabControl.Location = new System.Drawing.Point(11, 40);
            this.LoginTabControl.Name = "LoginTabControl";
            this.LoginTabControl.SelectedIndex = 0;
            this.LoginTabControl.Size = new System.Drawing.Size(328, 373);
            this.LoginTabControl.TabIndex = 0;
            // 
            // LoginPage
            // 
            this.LoginPage.Controls.Add(this.labelLoginFailed);
            this.LoginPage.Controls.Add(this.labelLoginPassword);
            this.LoginPage.Controls.Add(this.labelLoginName);
            this.LoginPage.Controls.Add(this.btnLogin);
            this.LoginPage.Controls.Add(this.txtBoxLoginPassword);
            this.LoginPage.Controls.Add(this.txtBoxLoginName);
            this.LoginPage.Location = new System.Drawing.Point(4, 22);
            this.LoginPage.Name = "LoginPage";
            this.LoginPage.Padding = new System.Windows.Forms.Padding(3);
            this.LoginPage.Size = new System.Drawing.Size(320, 347);
            this.LoginPage.TabIndex = 0;
            this.LoginPage.Text = "                Вход                  ";
            this.LoginPage.UseVisualStyleBackColor = true;
            // 
            // labelLoginFailed
            // 
            this.labelLoginFailed.AutoSize = true;
            this.labelLoginFailed.ForeColor = System.Drawing.Color.Red;
            this.labelLoginFailed.Location = new System.Drawing.Point(62, 37);
            this.labelLoginFailed.Name = "labelLoginFailed";
            this.labelLoginFailed.Size = new System.Drawing.Size(179, 13);
            this.labelLoginFailed.TabIndex = 5;
            this.labelLoginFailed.Text = "Неверно введено имя или пароль";
            // 
            // labelLoginPassword
            // 
            this.labelLoginPassword.AutoSize = true;
            this.labelLoginPassword.Location = new System.Drawing.Point(42, 136);
            this.labelLoginPassword.Name = "labelLoginPassword";
            this.labelLoginPassword.Size = new System.Drawing.Size(45, 13);
            this.labelLoginPassword.TabIndex = 4;
            this.labelLoginPassword.Text = "Пароль";
            // 
            // labelLoginName
            // 
            this.labelLoginName.AutoSize = true;
            this.labelLoginName.Location = new System.Drawing.Point(42, 78);
            this.labelLoginName.Name = "labelLoginName";
            this.labelLoginName.Size = new System.Drawing.Size(29, 13);
            this.labelLoginName.TabIndex = 3;
            this.labelLoginName.Text = "Имя";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(43, 208);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(230, 27);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Войти";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtBoxLoginPassword
            // 
            this.txtBoxLoginPassword.Location = new System.Drawing.Point(43, 152);
            this.txtBoxLoginPassword.Name = "txtBoxLoginPassword";
            this.txtBoxLoginPassword.Size = new System.Drawing.Size(230, 20);
            this.txtBoxLoginPassword.TabIndex = 1;
            // 
            // txtBoxLoginName
            // 
            this.txtBoxLoginName.Location = new System.Drawing.Point(43, 93);
            this.txtBoxLoginName.Name = "txtBoxLoginName";
            this.txtBoxLoginName.Size = new System.Drawing.Size(230, 20);
            this.txtBoxLoginName.TabIndex = 0;
            // 
            // RegistrationPage
            // 
            this.RegistrationPage.Controls.Add(this.labelRegistrationFailed);
            this.RegistrationPage.Controls.Add(this.labelRepeatPasswordFailed);
            this.RegistrationPage.Controls.Add(this.labelPasswordFailed);
            this.RegistrationPage.Controls.Add(this.labelNameFailed);
            this.RegistrationPage.Controls.Add(this.labelRepeatPassword);
            this.RegistrationPage.Controls.Add(this.labelRegistrationPassword);
            this.RegistrationPage.Controls.Add(this.labelRegistrationName);
            this.RegistrationPage.Controls.Add(this.btnRegistrationAsStudent);
            this.RegistrationPage.Controls.Add(this.btnRegistrationAsTeaher);
            this.RegistrationPage.Controls.Add(this.txtBoxRepeatPassword);
            this.RegistrationPage.Controls.Add(this.txtBoxRegistrationPassword);
            this.RegistrationPage.Controls.Add(this.txtBoxRegistrationName);
            this.RegistrationPage.Location = new System.Drawing.Point(4, 22);
            this.RegistrationPage.Name = "RegistrationPage";
            this.RegistrationPage.Padding = new System.Windows.Forms.Padding(3);
            this.RegistrationPage.Size = new System.Drawing.Size(320, 347);
            this.RegistrationPage.TabIndex = 1;
            this.RegistrationPage.Text = "                 Регистрация                  ";
            this.RegistrationPage.UseVisualStyleBackColor = true;
            // 
            // labelRegistrationFailed
            // 
            this.labelRegistrationFailed.AutoSize = true;
            this.labelRegistrationFailed.ForeColor = System.Drawing.Color.Red;
            this.labelRegistrationFailed.Location = new System.Drawing.Point(28, 17);
            this.labelRegistrationFailed.Name = "labelRegistrationFailed";
            this.labelRegistrationFailed.Size = new System.Drawing.Size(196, 13);
            this.labelRegistrationFailed.TabIndex = 11;
            this.labelRegistrationFailed.Text = "Такой пользователь уже существует";
            // 
            // labelRepeatPasswordFailed
            // 
            this.labelRepeatPasswordFailed.AutoSize = true;
            this.labelRepeatPasswordFailed.ForeColor = System.Drawing.Color.Red;
            this.labelRepeatPasswordFailed.Location = new System.Drawing.Point(28, 159);
            this.labelRepeatPasswordFailed.Name = "labelRepeatPasswordFailed";
            this.labelRepeatPasswordFailed.Size = new System.Drawing.Size(118, 13);
            this.labelRepeatPasswordFailed.TabIndex = 10;
            this.labelRepeatPasswordFailed.Text = "Пароли не совпадают";
            // 
            // labelPasswordFailed
            // 
            this.labelPasswordFailed.AutoSize = true;
            this.labelPasswordFailed.ForeColor = System.Drawing.Color.Red;
            this.labelPasswordFailed.Location = new System.Drawing.Point(28, 101);
            this.labelPasswordFailed.Name = "labelPasswordFailed";
            this.labelPasswordFailed.Size = new System.Drawing.Size(0, 13);
            this.labelPasswordFailed.TabIndex = 9;
            // 
            // labelNameFailed
            // 
            this.labelNameFailed.AutoSize = true;
            this.labelNameFailed.ForeColor = System.Drawing.Color.Red;
            this.labelNameFailed.Location = new System.Drawing.Point(28, 41);
            this.labelNameFailed.Name = "labelNameFailed";
            this.labelNameFailed.Size = new System.Drawing.Size(149, 13);
            this.labelNameFailed.TabIndex = 8;
            this.labelNameFailed.Text = "Имя не может быть пустым";
            // 
            // labelRepeatPassword
            // 
            this.labelRepeatPassword.AutoSize = true;
            this.labelRepeatPassword.Location = new System.Drawing.Point(28, 172);
            this.labelRepeatPassword.Name = "labelRepeatPassword";
            this.labelRepeatPassword.Size = new System.Drawing.Size(100, 13);
            this.labelRepeatPassword.TabIndex = 7;
            this.labelRepeatPassword.Text = "Повторить пароль";
            // 
            // labelRegistrationPassword
            // 
            this.labelRegistrationPassword.AutoSize = true;
            this.labelRegistrationPassword.Location = new System.Drawing.Point(28, 114);
            this.labelRegistrationPassword.Name = "labelRegistrationPassword";
            this.labelRegistrationPassword.Size = new System.Drawing.Size(45, 13);
            this.labelRegistrationPassword.TabIndex = 6;
            this.labelRegistrationPassword.Text = "Пароль";
            // 
            // labelRegistrationName
            // 
            this.labelRegistrationName.AutoSize = true;
            this.labelRegistrationName.Location = new System.Drawing.Point(28, 54);
            this.labelRegistrationName.Name = "labelRegistrationName";
            this.labelRegistrationName.Size = new System.Drawing.Size(29, 13);
            this.labelRegistrationName.TabIndex = 5;
            this.labelRegistrationName.Text = "Имя";
            // 
            // btnRegistrationAsStudent
            // 
            this.btnRegistrationAsStudent.Location = new System.Drawing.Point(48, 286);
            this.btnRegistrationAsStudent.Name = "btnRegistrationAsStudent";
            this.btnRegistrationAsStudent.Size = new System.Drawing.Size(230, 27);
            this.btnRegistrationAsStudent.TabIndex = 4;
            this.btnRegistrationAsStudent.Text = "Зарегистрироваться как студент";
            this.btnRegistrationAsStudent.UseVisualStyleBackColor = true;
            this.btnRegistrationAsStudent.Click += new System.EventHandler(this.btnRegistrationAsStudent_Click);
            // 
            // btnRegistrationAsTeaher
            // 
            this.btnRegistrationAsTeaher.Location = new System.Drawing.Point(48, 237);
            this.btnRegistrationAsTeaher.Name = "btnRegistrationAsTeaher";
            this.btnRegistrationAsTeaher.Size = new System.Drawing.Size(230, 27);
            this.btnRegistrationAsTeaher.TabIndex = 3;
            this.btnRegistrationAsTeaher.Text = "Зарегистрироваться как преподаватель";
            this.btnRegistrationAsTeaher.UseVisualStyleBackColor = true;
            this.btnRegistrationAsTeaher.Click += new System.EventHandler(this.btnRegistrationAsTeaher_Click);
            // 
            // txtBoxRepeatPassword
            // 
            this.txtBoxRepeatPassword.Location = new System.Drawing.Point(31, 188);
            this.txtBoxRepeatPassword.Name = "txtBoxRepeatPassword";
            this.txtBoxRepeatPassword.Size = new System.Drawing.Size(257, 20);
            this.txtBoxRepeatPassword.TabIndex = 2;
            // 
            // txtBoxRegistrationPassword
            // 
            this.txtBoxRegistrationPassword.Location = new System.Drawing.Point(31, 130);
            this.txtBoxRegistrationPassword.Name = "txtBoxRegistrationPassword";
            this.txtBoxRegistrationPassword.Size = new System.Drawing.Size(257, 20);
            this.txtBoxRegistrationPassword.TabIndex = 1;
            // 
            // txtBoxRegistrationName
            // 
            this.txtBoxRegistrationName.Location = new System.Drawing.Point(31, 70);
            this.txtBoxRegistrationName.Name = "txtBoxRegistrationName";
            this.txtBoxRegistrationName.Size = new System.Drawing.Size(257, 20);
            this.txtBoxRegistrationName.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(190, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(148, 27);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Выйти";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 425);
            this.ControlBox = false;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.LoginTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "LoginForm";
            this.Text = "Вход/Регистрация";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.LoginTabControl.ResumeLayout(false);
            this.LoginPage.ResumeLayout(false);
            this.LoginPage.PerformLayout();
            this.RegistrationPage.ResumeLayout(false);
            this.RegistrationPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl LoginTabControl;
        private System.Windows.Forms.TabPage LoginPage;
        private System.Windows.Forms.TabPage RegistrationPage;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtBoxLoginPassword;
        private System.Windows.Forms.TextBox txtBoxLoginName;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnRegistrationAsStudent;
        private System.Windows.Forms.Button btnRegistrationAsTeaher;
        private System.Windows.Forms.TextBox txtBoxRepeatPassword;
        private System.Windows.Forms.TextBox txtBoxRegistrationPassword;
        private System.Windows.Forms.TextBox txtBoxRegistrationName;
        private System.Windows.Forms.Label labelLoginFailed;
        private System.Windows.Forms.Label labelLoginPassword;
        private System.Windows.Forms.Label labelLoginName;
        private System.Windows.Forms.Label labelRepeatPassword;
        private System.Windows.Forms.Label labelRegistrationPassword;
        private System.Windows.Forms.Label labelRegistrationName;
        private System.Windows.Forms.Label labelRepeatPasswordFailed;
        private System.Windows.Forms.Label labelPasswordFailed;
        private System.Windows.Forms.Label labelNameFailed;
        private System.Windows.Forms.Label labelRegistrationFailed;
    }
}