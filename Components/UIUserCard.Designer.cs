namespace NRoomS
{
    partial class UIUserCard
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            _log_out = new Button();
            _login = new Label();
            SuspendLayout();
            // 
            // _log_out
            // 
            _log_out.Dock = DockStyle.Right;
            _log_out.Location = new Point(154, 0);
            _log_out.Name = "_log_out";
            _log_out.Size = new Size(71, 59);
            _log_out.TabIndex = 0;
            _log_out.Text = "logout";
            _log_out.UseVisualStyleBackColor = true;
            _log_out.Click += _log_out_Click;
            // 
            // _login
            // 
            _login.AutoSize = true;
            _login.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            _login.Location = new Point(0, 18);
            _login.Name = "_login";
            _login.Size = new Size(52, 21);
            _login.TabIndex = 1;
            _login.Text = "_login";
            // 
            // UIUserCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(_login);
            Controls.Add(_log_out);
            Name = "UIUserCard";
            Size = new Size(225, 59);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button _log_out;
        private Label _login;
    }
}
