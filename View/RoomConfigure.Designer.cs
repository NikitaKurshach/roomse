namespace Roommse
{
    partial class RoomConfigure
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
            _send = new Button();
            label1 = new Label();
            _images = new FlowLayoutPanel();
            label2 = new Label();
            _title = new TextBox();
            label3 = new Label();
            label4 = new Label();
            _type = new ComboBox();
            label5 = new Label();
            _city = new TextBox();
            label7 = new Label();
            _address = new TextBox();
            label6 = new Label();
            label8 = new Label();
            _room_count = new NumericUpDown();
            _solar = new NumericUpDown();
            _description = new RichTextBox();
            _is_shop = new CheckBox();
            _is_parking = new CheckBox();
            _is_noisy_neighbors = new CheckBox();
            _is_school = new CheckBox();
            _is_kindergarten = new CheckBox();
            _is_park = new CheckBox();
            button1 = new Button();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)_room_count).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_solar).BeginInit();
            SuspendLayout();
            // 
            // _send
            // 
            _send.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            _send.Location = new Point(744, 818);
            _send.Margin = new Padding(4, 3, 4, 3);
            _send.Name = "_send";
            _send.Size = new Size(215, 68);
            _send.TabIndex = 0;
            _send.Text = "Отправить";
            _send.UseVisualStyleBackColor = true;
            _send.Click += _send_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(14, 614);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(254, 20);
            label1.TabIndex = 2;
            label1.Text = "Перетащите сюда изображения";
            // 
            // _images
            // 
            _images.BackColor = Color.Transparent;
            _images.BorderStyle = BorderStyle.FixedSingle;
            _images.ForeColor = Color.White;
            _images.Location = new Point(14, 640);
            _images.Margin = new Padding(4, 3, 4, 3);
            _images.Name = "_images";
            _images.Size = new Size(716, 245);
            _images.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(9, 22);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(213, 20);
            label2.TabIndex = 4;
            label2.Text = "Наименование помещения";
            // 
            // _title
            // 
            _title.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            _title.Location = new Point(265, 18);
            _title.Margin = new Padding(4, 3, 4, 3);
            _title.Name = "_title";
            _title.Size = new Size(686, 26);
            _title.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(9, 59);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(93, 20);
            label3.TabIndex = 6;
            label3.Text = "Стоимость";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(14, 96);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(40, 20);
            label4.TabIndex = 8;
            label4.Text = "Вид";
            // 
            // _type
            // 
            _type.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            _type.FormattingEnabled = true;
            _type.Items.AddRange(new object[] { "Аренда", "Продажа" });
            _type.Location = new Point(265, 92);
            _type.Margin = new Padding(4, 3, 4, 3);
            _type.Name = "_type";
            _type.Size = new Size(262, 28);
            _type.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(14, 135);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(159, 20);
            label5.TabIndex = 10;
            label5.Text = "Количество комнат";
            // 
            // _city
            // 
            _city.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            _city.Location = new Point(265, 172);
            _city.Margin = new Padding(4, 3, 4, 3);
            _city.Name = "_city";
            _city.Size = new Size(686, 26);
            _city.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(14, 172);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(56, 20);
            label7.TabIndex = 16;
            label7.Text = "Город";
            // 
            // _address
            // 
            _address.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            _address.Location = new Point(265, 209);
            _address.Margin = new Padding(4, 3, 4, 3);
            _address.Name = "_address";
            _address.Size = new Size(686, 26);
            _address.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(14, 209);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(57, 20);
            label6.TabIndex = 18;
            label6.Text = "Адрес";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(14, 253);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(83, 20);
            label8.TabIndex = 20;
            label8.Text = "Описание";
            // 
            // _room_count
            // 
            _room_count.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            _room_count.Location = new Point(265, 132);
            _room_count.Margin = new Padding(4, 3, 4, 3);
            _room_count.Name = "_room_count";
            _room_count.Size = new Size(140, 26);
            _room_count.TabIndex = 22;
            // 
            // _solar
            // 
            _solar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            _solar.Increment = new decimal(new int[] { 1000, 0, 0, 0 });
            _solar.Location = new Point(265, 55);
            _solar.Margin = new Padding(4, 3, 4, 3);
            _solar.Maximum = new decimal(new int[] { -727379968, 232, 0, 0 });
            _solar.Name = "_solar";
            _solar.Size = new Size(140, 26);
            _solar.TabIndex = 23;
            // 
            // _description
            // 
            _description.AutoWordSelection = true;
            _description.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            _description.ImeMode = ImeMode.Off;
            _description.Location = new Point(118, 253);
            _description.Margin = new Padding(4, 3, 4, 3);
            _description.Name = "_description";
            _description.Size = new Size(834, 227);
            _description.TabIndex = 24;
            _description.Text = "";
            // 
            // _is_shop
            // 
            _is_shop.AutoSize = true;
            _is_shop.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            _is_shop.Location = new Point(118, 487);
            _is_shop.Margin = new Padding(4, 3, 4, 3);
            _is_shop.Name = "_is_shop";
            _is_shop.Size = new Size(145, 24);
            _is_shop.TabIndex = 25;
            _is_shop.Text = "Магазин рядом";
            _is_shop.UseVisualStyleBackColor = true;
            // 
            // _is_parking
            // 
            _is_parking.AutoSize = true;
            _is_parking.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            _is_parking.Location = new Point(118, 522);
            _is_parking.Margin = new Padding(4, 3, 4, 3);
            _is_parking.Name = "_is_parking";
            _is_parking.Size = new Size(101, 24);
            _is_parking.TabIndex = 26;
            _is_parking.Text = "Парковка";
            _is_parking.UseVisualStyleBackColor = true;
            // 
            // _is_noisy_neighbors
            // 
            _is_noisy_neighbors.AutoSize = true;
            _is_noisy_neighbors.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            _is_noisy_neighbors.Location = new Point(294, 487);
            _is_noisy_neighbors.Margin = new Padding(4, 3, 4, 3);
            _is_noisy_neighbors.Name = "_is_noisy_neighbors";
            _is_noisy_neighbors.Size = new Size(146, 24);
            _is_noisy_neighbors.TabIndex = 27;
            _is_noisy_neighbors.Text = "Шумные соседи";
            _is_noisy_neighbors.UseVisualStyleBackColor = true;
            // 
            // _is_school
            // 
            _is_school.AutoSize = true;
            _is_school.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            _is_school.Location = new Point(294, 522);
            _is_school.Margin = new Padding(4, 3, 4, 3);
            _is_school.Name = "_is_school";
            _is_school.Size = new Size(160, 24);
            _is_school.TabIndex = 28;
            _is_school.Text = "рядом со Школой";
            _is_school.UseVisualStyleBackColor = true;
            // 
            // _is_kindergarten
            // 
            _is_kindergarten.AutoSize = true;
            _is_kindergarten.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            _is_kindergarten.Location = new Point(484, 487);
            _is_kindergarten.Margin = new Padding(4, 3, 4, 3);
            _is_kindergarten.Name = "_is_kindergarten";
            _is_kindergarten.Size = new Size(211, 24);
            _is_kindergarten.TabIndex = 29;
            _is_kindergarten.Text = "рядом с Детским садом";
            _is_kindergarten.UseVisualStyleBackColor = true;
            // 
            // _is_park
            // 
            _is_park.AutoSize = true;
            _is_park.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            _is_park.Location = new Point(484, 522);
            _is_park.Margin = new Padding(4, 3, 4, 3);
            _is_park.Name = "_is_park";
            _is_park.Size = new Size(148, 24);
            _is_park.TabIndex = 30;
            _is_park.Text = "рядом с парком";
            _is_park.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(813, 632);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(139, 39);
            button1.TabIndex = 31;
            button1.Text = "просмотра";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(737, 640);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(59, 20);
            label9.TabIndex = 32;
            label9.Text = "Режим";
            // 
            // RoomConfigure
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(973, 901);
            Controls.Add(label9);
            Controls.Add(button1);
            Controls.Add(_is_park);
            Controls.Add(_is_kindergarten);
            Controls.Add(_is_school);
            Controls.Add(_is_noisy_neighbors);
            Controls.Add(_is_parking);
            Controls.Add(_is_shop);
            Controls.Add(_description);
            Controls.Add(_solar);
            Controls.Add(_room_count);
            Controls.Add(label8);
            Controls.Add(_address);
            Controls.Add(label6);
            Controls.Add(_city);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(_type);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(_title);
            Controls.Add(label2);
            Controls.Add(_images);
            Controls.Add(label1);
            Controls.Add(_send);
            Margin = new Padding(4, 3, 4, 3);
            Name = "RoomConfigure";
            Text = "Form1";
            Load += RoomConfigure_Load;
            ((System.ComponentModel.ISupportInitialize)_room_count).EndInit();
            ((System.ComponentModel.ISupportInitialize)_solar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button _send;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel _images;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _title;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox _type;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox _city;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox _address;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown _room_count;
        private System.Windows.Forms.NumericUpDown _solar;
        private System.Windows.Forms.RichTextBox _description;
        private System.Windows.Forms.CheckBox _is_shop;
        private System.Windows.Forms.CheckBox _is_parking;
        private System.Windows.Forms.CheckBox _is_noisy_neighbors;
        private System.Windows.Forms.CheckBox _is_school;
        private System.Windows.Forms.CheckBox _is_kindergarten;
        private System.Windows.Forms.CheckBox _is_park;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
    }
}

