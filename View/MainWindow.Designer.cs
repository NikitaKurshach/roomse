namespace NRoomS
{
    partial class MainWindow
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
            components = new System.ComponentModel.Container();
            splitContainer1 = new SplitContainer();
            _button_panel = new FlowLayoutPanel();
            _baseBTN = new Button();
            _user_panel = new UIUserCard();
            _card_panel = new FlowLayoutPanel();
            _config_panel = new Panel();
            _tags = new Label();
            _tags_box = new CheckedListBox();
            _city = new Label();
            comboBox1 = new ComboBox();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            _button_panel.SuspendLayout();
            _config_panel.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.FixedPanel = FixedPanel.Panel1;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(_button_panel);
            splitContainer1.Panel1.Controls.Add(_user_panel);
            splitContainer1.Panel1MinSize = 266;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(_card_panel);
            splitContainer1.Panel2.Controls.Add(_config_panel);
            splitContainer1.Size = new Size(843, 453);
            splitContainer1.SplitterDistance = 266;
            splitContainer1.SplitterWidth = 1;
            splitContainer1.TabIndex = 0;
            // 
            // _button_panel
            // 
            _button_panel.BorderStyle = BorderStyle.FixedSingle;
            _button_panel.Controls.Add(_baseBTN);
            _button_panel.Dock = DockStyle.Fill;
            _button_panel.Location = new Point(0, 61);
            _button_panel.MaximumSize = new Size(266, 0);
            _button_panel.Name = "_button_panel";
            _button_panel.Size = new Size(266, 392);
            _button_panel.TabIndex = 1;
            // 
            // _baseBTN
            // 
            _baseBTN.AutoSize = true;
            _baseBTN.Dock = DockStyle.Fill;
            _baseBTN.Location = new Point(3, 3);
            _baseBTN.Name = "_baseBTN";
            _baseBTN.Size = new Size(260, 54);
            _baseBTN.TabIndex = 0;
            _baseBTN.Text = "BaseButton";
            _baseBTN.UseVisualStyleBackColor = true;
            // 
            // _user_panel
            // 
            _user_panel.BorderStyle = BorderStyle.FixedSingle;
            _user_panel.Dock = DockStyle.Top;
            _user_panel.Location = new Point(0, 0);
            _user_panel.MaximumSize = new Size(266, 61);
            _user_panel.Name = "_user_panel";
            _user_panel.Size = new Size(266, 61);
            _user_panel.TabIndex = 0;
            // 
            // _card_panel
            // 
            _card_panel.AutoScroll = true;
            _card_panel.Dock = DockStyle.Fill;
            _card_panel.Location = new Point(0, 118);
            _card_panel.Name = "_card_panel";
            _card_panel.Size = new Size(576, 335);
            _card_panel.TabIndex = 1;
            // 
            // _config_panel
            // 
            _config_panel.BorderStyle = BorderStyle.FixedSingle;
            _config_panel.Controls.Add(_tags);
            _config_panel.Controls.Add(_tags_box);
            _config_panel.Controls.Add(_city);
            _config_panel.Controls.Add(comboBox1);
            _config_panel.Dock = DockStyle.Top;
            _config_panel.Location = new Point(0, 0);
            _config_panel.Name = "_config_panel";
            _config_panel.Size = new Size(576, 118);
            _config_panel.TabIndex = 0;
            // 
            // _tags
            // 
            _tags.AutoSize = true;
            _tags.Location = new Point(193, 15);
            _tags.Name = "_tags";
            _tags.Size = new Size(31, 15);
            _tags.TabIndex = 3;
            _tags.Text = "Теги";
            // 
            // _tags_box
            // 
            _tags_box.BackColor = SystemColors.Menu;
            _tags_box.FormattingEnabled = true;
            _tags_box.Location = new Point(237, 12);
            _tags_box.Name = "_tags_box";
            _tags_box.Size = new Size(131, 94);
            _tags_box.TabIndex = 2;
            _tags_box.MouseUp += _tags_box_SelectedIndexChanged;
            // 
            // _city
            // 
            _city.AutoSize = true;
            _city.Location = new Point(3, 15);
            _city.Name = "_city";
            _city.Size = new Size(40, 15);
            _city.TabIndex = 1;
            _city.Text = "Город";
            // 
            // comboBox1
            // 
            comboBox1.DisplayMember = "0";
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Все" });
            comboBox1.Location = new Point(49, 12);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(138, 23);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(843, 453);
            Controls.Add(splitContainer1);
            MinimumSize = new Size(859, 492);
            Name = "MainWindow";
            Text = "pan";
            Load += MainWindow_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            _button_panel.ResumeLayout(false);
            _button_panel.PerformLayout();
            _config_panel.ResumeLayout(false);
            _config_panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private UIUserCard _user_panel;
        private FlowLayoutPanel _button_panel;
        private Button _baseBTN;
        private FlowLayoutPanel _card_panel;
        private Panel _config_panel;
        private Label _tags;
        private CheckedListBox _tags_box;
        private Label _city;
        private ComboBox comboBox1;
        private System.Windows.Forms.Timer timer1;
    }
}