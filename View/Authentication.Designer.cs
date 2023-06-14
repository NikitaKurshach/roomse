namespace NRoomS
{
    partial class Authentication
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
            _TabController = new TabControl();
            Auth = new TabPage();
            _saveUser = new CheckBox();
            _auth_button = new Button();
            label2 = new Label();
            label1 = new Label();
            _auth_password = new TextBox();
            _auth_login = new TextBox();
            Reg = new TabPage();
            label5 = new Label();
            _reg_password2 = new TextBox();
            _reg_button = new Button();
            label3 = new Label();
            label4 = new Label();
            _reg_password1 = new TextBox();
            _reg_login = new TextBox();
            _TabController.SuspendLayout();
            Auth.SuspendLayout();
            Reg.SuspendLayout();
            SuspendLayout();
            // 
            // _TabController
            // 
            _TabController.Controls.Add(Auth);
            _TabController.Controls.Add(Reg);
            _TabController.Dock = DockStyle.Fill;
            _TabController.Location = new Point(0, 0);
            _TabController.Margin = new Padding(4, 3, 4, 3);
            _TabController.Name = "_TabController";
            _TabController.SelectedIndex = 0;
            _TabController.Size = new Size(386, 353);
            _TabController.TabIndex = 0;
            // 
            // Auth
            // 
            Auth.Controls.Add(_saveUser);
            Auth.Controls.Add(_auth_button);
            Auth.Controls.Add(label2);
            Auth.Controls.Add(label1);
            Auth.Controls.Add(_auth_password);
            Auth.Controls.Add(_auth_login);
            Auth.Location = new Point(4, 24);
            Auth.Margin = new Padding(4, 3, 4, 3);
            Auth.Name = "Auth";
            Auth.Padding = new Padding(4, 3, 4, 3);
            Auth.Size = new Size(378, 325);
            Auth.TabIndex = 0;
            Auth.Text = "Вход";
            Auth.UseVisualStyleBackColor = true;
            // 
            // _saveUser
            // 
            _saveUser.AutoSize = true;
            _saveUser.Location = new Point(5, 133);
            _saveUser.Margin = new Padding(4, 3, 4, 3);
            _saveUser.Name = "_saveUser";
            _saveUser.Size = new Size(118, 19);
            _saveUser.TabIndex = 5;
            _saveUser.Text = "Запомнить меня";
            _saveUser.UseVisualStyleBackColor = true;
            // 
            // _auth_button
            // 
            _auth_button.Location = new Point(7, 268);
            _auth_button.Margin = new Padding(4, 3, 4, 3);
            _auth_button.Name = "_auth_button";
            _auth_button.Size = new Size(363, 48);
            _auth_button.TabIndex = 4;
            _auth_button.Text = "Войти";
            _auth_button.UseVisualStyleBackColor = true;
            _auth_button.Click += _auth_button_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(2, 69);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 3;
            label2.Text = "Пароль";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(2, 3);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 2;
            label1.Text = "Логин";
            // 
            // _auth_password
            // 
            _auth_password.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            _auth_password.Location = new Point(5, 96);
            _auth_password.Margin = new Padding(4, 3, 4, 3);
            _auth_password.Name = "_auth_password";
            _auth_password.PasswordChar = '*';
            _auth_password.Size = new Size(358, 26);
            _auth_password.TabIndex = 1;
            // 
            // _auth_login
            // 
            _auth_login.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            _auth_login.Location = new Point(5, 30);
            _auth_login.Margin = new Padding(4, 3, 4, 3);
            _auth_login.Name = "_auth_login";
            _auth_login.Size = new Size(358, 26);
            _auth_login.TabIndex = 0;
            // 
            // Reg
            // 
            Reg.Controls.Add(label5);
            Reg.Controls.Add(_reg_password2);
            Reg.Controls.Add(_reg_button);
            Reg.Controls.Add(label3);
            Reg.Controls.Add(label4);
            Reg.Controls.Add(_reg_password1);
            Reg.Controls.Add(_reg_login);
            Reg.Location = new Point(4, 24);
            Reg.Margin = new Padding(4, 3, 4, 3);
            Reg.Name = "Reg";
            Reg.Padding = new Padding(4, 3, 4, 3);
            Reg.Size = new Size(378, 325);
            Reg.TabIndex = 1;
            Reg.Text = "Регистрация";
            Reg.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(5, 137);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(152, 20);
            label5.TabIndex = 11;
            label5.Text = "Повторите пароль";
            // 
            // _reg_password2
            // 
            _reg_password2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            _reg_password2.Location = new Point(7, 164);
            _reg_password2.Margin = new Padding(4, 3, 4, 3);
            _reg_password2.Name = "_reg_password2";
            _reg_password2.PasswordChar = '*';
            _reg_password2.Size = new Size(358, 26);
            _reg_password2.TabIndex = 7;
            // 
            // _reg_button
            // 
            _reg_button.Location = new Point(7, 268);
            _reg_button.Margin = new Padding(4, 3, 4, 3);
            _reg_button.Name = "_reg_button";
            _reg_button.Size = new Size(363, 48);
            _reg_button.TabIndex = 8;
            _reg_button.Text = "Регистрация";
            _reg_button.UseVisualStyleBackColor = true;
            _reg_button.Click += _reg_button_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(2, 69);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 8;
            label3.Text = "Пароль";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(2, 3);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 7;
            label4.Text = "Логин";
            // 
            // _reg_password1
            // 
            _reg_password1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            _reg_password1.Location = new Point(5, 96);
            _reg_password1.Margin = new Padding(4, 3, 4, 3);
            _reg_password1.Name = "_reg_password1";
            _reg_password1.PasswordChar = '*';
            _reg_password1.Size = new Size(358, 26);
            _reg_password1.TabIndex = 6;
            // 
            // _reg_login
            // 
            _reg_login.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            _reg_login.Location = new Point(5, 30);
            _reg_login.Margin = new Padding(4, 3, 4, 3);
            _reg_login.Name = "_reg_login";
            _reg_login.Size = new Size(358, 26);
            _reg_login.TabIndex = 5;
            // 
            // Authentication
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(386, 353);
            Controls.Add(_TabController);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Authentication";
            Text = "Authentication";
            Load += Authentication_Load;
            _TabController.ResumeLayout(false);
            Auth.ResumeLayout(false);
            Auth.PerformLayout();
            Reg.ResumeLayout(false);
            Reg.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl _TabController;
        private System.Windows.Forms.TabPage Auth;
        private System.Windows.Forms.TabPage Reg;
        private System.Windows.Forms.TextBox _auth_password;
        private System.Windows.Forms.TextBox _auth_login;
        private System.Windows.Forms.CheckBox _saveUser;
        private System.Windows.Forms.Button _auth_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox _reg_password2;
        private System.Windows.Forms.Button _reg_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox _reg_password1;
        private System.Windows.Forms.TextBox _reg_login;
    }
}