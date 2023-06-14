namespace NRoomS
{
    partial class UICard
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
            pictureBox1 = new PictureBox();
            _solar = new Label();
            _name = new Label();
            _address = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(272, 133);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // _solar
            // 
            _solar.AutoSize = true;
            _solar.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            _solar.Location = new Point(84, 196);
            _solar.Name = "_solar";
            _solar.Size = new Size(50, 20);
            _solar.TabIndex = 1;
            _solar.Text = "label1";
            // 
            // _name
            // 
            _name.AutoSize = true;
            _name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            _name.Location = new Point(3, 112);
            _name.Name = "_name";
            _name.Size = new Size(52, 21);
            _name.TabIndex = 2;
            _name.Text = "label1";
            // 
            // _address
            // 
            _address.AutoSize = true;
            _address.Location = new Point(51, 136);
            _address.Name = "_address";
            _address.Size = new Size(38, 15);
            _address.TabIndex = 3;
            _address.Text = "label1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(2, 136);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 4;
            label1.Text = "Адрес:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 201);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 5;
            label2.Text = "Стоимость:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(2, 151);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 6;
            label3.Text = "Теги:";
            // 
            // label4
            // 
            label4.Location = new Point(51, 151);
            label4.Name = "label4";
            label4.Size = new Size(217, 45);
            label4.TabIndex = 7;
            label4.Text = "label1";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(42, 219);
            label5.Name = "label5";
            label5.Size = new Size(19, 21);
            label5.TabIndex = 8;
            label5.Text = "0";
            // 
            // pictureBox2
            // 
            pictureBox2.ImageLocation = "https://free-png.ru/wp-content/uploads/2021/06/free-png.ru-48.png";
            pictureBox2.Location = new Point(15, 219);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(21, 21);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // UICard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(pictureBox2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(_address);
            Controls.Add(_name);
            Controls.Add(_solar);
            Controls.Add(pictureBox1);
            Name = "UICard";
            Size = new Size(271, 247);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label _solar;
        private Label _name;
        private Label _address;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox2;
    }
}
