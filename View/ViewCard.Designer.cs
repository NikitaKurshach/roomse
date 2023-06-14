namespace NRoomS
{
    partial class ViewCard
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
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            _solar = new NumericUpDown();
            _type = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            _description = new RichTextBox();
            label8 = new Label();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_solar).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(442, 287);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(12, 299);
            button1.Name = "button1";
            button1.Size = new Size(157, 32);
            button1.TabIndex = 1;
            button1.Text = "<";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button2.Location = new Point(298, 299);
            button2.Name = "button2";
            button2.Size = new Size(156, 32);
            button2.TabIndex = 2;
            button2.Text = ">";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Window;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(582, 9);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(215, 29);
            textBox1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(460, 12);
            label1.Name = "label1";
            label1.Size = new Size(117, 21);
            label1.TabIndex = 4;
            label1.Text = "Наименование";
            // 
            // _solar
            // 
            _solar.BorderStyle = BorderStyle.FixedSingle;
            _solar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            _solar.Increment = new decimal(new int[] { 1000, 0, 0, 0 });
            _solar.Location = new Point(582, 44);
            _solar.Margin = new Padding(4, 3, 4, 3);
            _solar.Maximum = new decimal(new int[] { -727379968, 232, 0, 0 });
            _solar.Name = "_solar";
            _solar.ReadOnly = true;
            _solar.Size = new Size(140, 26);
            _solar.TabIndex = 27;
            // 
            // _type
            // 
            _type.FlatStyle = FlatStyle.Flat;
            _type.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            _type.FormattingEnabled = true;
            _type.Items.AddRange(new object[] { "Аренда", "Продажа" });
            _type.Location = new Point(582, 73);
            _type.Margin = new Padding(4, 3, 4, 3);
            _type.Name = "_type";
            _type.Size = new Size(215, 28);
            _type.TabIndex = 26;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(460, 81);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(40, 20);
            label4.TabIndex = 25;
            label4.Text = "Вид";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(460, 50);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(93, 20);
            label3.TabIndex = 24;
            label3.Text = "Стоимость";
            // 
            // _description
            // 
            _description.AutoWordSelection = true;
            _description.BorderStyle = BorderStyle.None;
            _description.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            _description.ImeMode = ImeMode.Off;
            _description.Location = new Point(103, 353);
            _description.Margin = new Padding(4, 3, 4, 3);
            _description.Name = "_description";
            _description.Size = new Size(689, 204);
            _description.TabIndex = 29;
            _description.Text = "";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(12, 343);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(83, 20);
            label8.TabIndex = 28;
            label8.Text = "Описание";
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(722, 563);
            button3.Name = "button3";
            button3.Size = new Size(75, 65);
            button3.TabIndex = 30;
            button3.Text = "Лайк";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(135, 563);
            button4.Name = "button4";
            button4.Size = new Size(577, 65);
            button4.TabIndex = 31;
            button4.Text = "Приобрести";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.FlatStyle = FlatStyle.Flat;
            button5.Location = new Point(12, 563);
            button5.Name = "button5";
            button5.Size = new Size(389, 65);
            button5.TabIndex = 32;
            button5.Text = "Изменить";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.FlatStyle = FlatStyle.Flat;
            button6.Location = new Point(451, 563);
            button6.Name = "button6";
            button6.Size = new Size(261, 65);
            button6.TabIndex = 33;
            button6.Text = "Выставить на продажу";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // ViewCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(805, 640);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(_description);
            Controls.Add(label8);
            Controls.Add(_solar);
            Controls.Add(_type);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Name = "ViewCard";
            Text = "ViewCard";
            Load += ViewCard_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)_solar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private Label label1;
        private NumericUpDown _solar;
        private ComboBox _type;
        private Label label4;
        private Label label3;
        private RichTextBox _description;
        private Label label8;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}