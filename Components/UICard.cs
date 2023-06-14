using Lib;
using NRoomS.controller;

namespace NRoomS
{
    public partial class UICard : UserControl
    {
        public string id, name, address, UserId;
        public int solar;
        public List<string> tags = new List<string>();

        // Метод для преобразования массива байтов в изображение
        public static Bitmap ByteToImage(MemoryStream mStream)
        {
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }

        public UICard(string id, GlobalManager globalManager, string UserId)
        {
            InitializeComponent();
            this.UserId = UserId;

            var card = globalManager.Post.GetPostById(id);
            this.id = id;
            this.name = card.Title;
            this.solar = card.Solar;
            this.address = card.Address;
            this.tags = card.Tags;

            label5.Text = $"{card.Like.Count}"; // Отображение количества лайков на метке
            label4.Text = "";
            foreach (var item in tags)
            {
                label4.Text += item + ", "; // Отображение тегов на метке
            }

            pictureBox1.Image = ByteToImage(globalManager.Image.GetImageById(card.Images[0])); // Загрузка изображения для отображения на метке

            _name.Text = name;
            _solar.Text = $"{solar}р";
            _address.Text = address;

            foreach (Control item in Controls)
            {
                item.Click += (s, e) =>
                {
                    new ViewCard(UserId, id, globalManager).ShowDialog(); // Открытие карточки для просмотра по клику на метке
                };
            }
        }
    }
}
