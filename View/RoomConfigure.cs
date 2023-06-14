using System.Diagnostics;
using Lib.Models;
using NRoomS.controller;

namespace Roommse
{
    public partial class RoomConfigure : Form
    {
        GlobalManager globalManager;
        private bool mode_img = false;
        string user_id;

        public RoomConfigure(string user_id, GlobalManager globalManager)
        {
            InitializeComponent();
            this.globalManager = globalManager;
            this.user_id = user_id;

            _images.AllowDrop = true;
            _images.AutoScroll = true;
            _images.DragEnter += new DragEventHandler(panel1_DragEnter);
            _images.DragDrop += new DragEventHandler(panel1_DragDrop);
        }

        // Обработчик события при перетаскивании файла в панель
        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                string extension = System.IO.Path.GetExtension(files[0]);
                // Проверяем расширение файла
                if (extension.Equals(".jpg", StringComparison.InvariantCultureIgnoreCase) ||
                    extension.Equals(".jpeg", StringComparison.InvariantCultureIgnoreCase) ||
                    extension.Equals(".png", StringComparison.InvariantCultureIgnoreCase) ||
                    extension.Equals(".bmp", StringComparison.InvariantCultureIgnoreCase))
                {
                    e.Effect = DragDropEffects.Copy; // Устанавливаем эффект перетаскивания
                }
            }
        }

        // Обработчик события при отпускании файла в панели
        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            if (files.Length > 0)
            {
                string filePath = files[0];

                // Проверка наличия пробелов в имени файла
                if (Path.GetFileName(filePath).Contains(" "))
                {
                    Console.WriteLine("Имя файла содержит пробелы.");
                }

                // Проверка наличия русских букв в имени файла
                bool containsRussianLetters = false;
                foreach (char c in Path.GetFileName(filePath))
                {
                    if (IsRussianLetter(c))
                    {
                        containsRussianLetters = true;
                        break;
                    }
                }
                if (containsRussianLetters)
                {
                    MessageBox.Show("Имя файла содержит русские буквы. Пожалуйста добавьте изображение в названии которого нет кириллицы и пробелов");
                    return;
                }

                string extension = System.IO.Path.GetExtension(filePath);
                if (extension.Equals(".jpg", StringComparison.InvariantCultureIgnoreCase) ||
                    extension.Equals(".jpeg", StringComparison.InvariantCultureIgnoreCase) ||
                    extension.Equals(".png", StringComparison.InvariantCultureIgnoreCase) ||
                    extension.Equals(".bmp", StringComparison.InvariantCultureIgnoreCase))
                {
                    Image image = Image.FromFile(filePath);

                    var _img = new PictureBox()
                    {
                        ImageLocation = filePath,
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Width = image.Width / 10,
                        Height = image.Height / 10,
                        Tag = filePath,
                    };

                    // Обработчик события клика по изображению
                    _img.Click += (object s, EventArgs ev) =>
                    {
                        if (mode_img)
                        {
                            ((PictureBox)s).Dispose(); // Удаляем изображение при режиме удаления
                        }
                        else
                        {
                            var p = new Process();
                            p.StartInfo = new ProcessStartInfo((string)((PictureBox)s).Tag)
                            {
                                UseShellExecute = true
                            };
                            p.Start();
                        }
                    };

                    _images.Controls.Add(_img); // Добавляем изображение в панель
                }
            }
        }

        // Проверяет, является ли символ русской буквой
        bool IsRussianLetter(char c)
        {
            int code = (int)c;
            return (code >= 1040 && code <= 1103) || code == 1025 || code == 1105;
        }

        // Обработчик события клика по кнопке "button1"
        private void button1_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            this.Text = $"{mode_img}";
            if (mode_img)
            {
                btn.Text = "просмотра";
                btn.ForeColor = Color.Black;
                mode_img = false;
            }
            else
            {
                btn.Text = "удаления";
                btn.ForeColor = Color.Red;
                mode_img = true;
            }
        }

        // Обработчик события клика по кнопке "_send"
        private async void _send_Click(object sender, EventArgs e)
        {
            List<string> imageList = new List<string>();

            // Добавление изображений в список и сохранение их в базе данных
            foreach (PictureBox item in _images.Controls)
            {
                var location = item.ImageLocation;
                var image_id = globalManager.Image.AddImage(location);
                imageList.Add(image_id);
            }

            if (imageList.Count == 0)
            {
                MessageBox.Show("Добавьте фото");
                return;
            }

            var clickedTags = new List<string>();
            var arrayTags = new List<CheckBox>() { _is_shop, _is_park, _is_parking, _is_school, _is_noisy_neighbors, _is_kindergarten };

            // Получение выбранных тегов
            foreach (CheckBox item in arrayTags)
            {
                if (item.Checked)
                {
                    clickedTags.Add(item.Text);
                }
            }

            // Создание новой записи
            Post obj = new()
            {
                Title = _title.Text,
                Images = imageList,
                Type = _type.Text,
                City = _city.Text,
                Address = _address.Text,
                Description = _description.Text,
                CreatedAt = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss"),
                Solar = (int)_solar.Value,
                Tags = clickedTags,
                OwnerId = user_id,
                Visible = true
            };

            globalManager.Post.CreatePost(obj);
            DialogResult = DialogResult.OK;
        }

        private void RoomConfigure_Load(object sender, EventArgs e)
        {

        }
    }
}
