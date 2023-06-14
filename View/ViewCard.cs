using Lib;
using Lib.Models;
using NRoomS.controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace NRoomS
{
    public partial class ViewCard : Form
    {
        Post Card;
        bool readMode = false;
        string UserId;
        GlobalManager globalManager;
        private int imagePointer = 0;

        // Метод для преобразования массива байтов в изображение
        public static Bitmap ByteToImage(MemoryStream mStream)
        {
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }

        public ViewCard(string UserId, string CardId, GlobalManager globalManager)
        {
            InitializeComponent();

            this.globalManager = globalManager;
            Card = globalManager.Post.GetPostById(CardId);
            this.UserId = UserId;

            pictureBox1.Image = ByteToImage(globalManager.Image.GetImageById(Card.Images[imagePointer]));

            textBox1.Text = Card.Title;
            _solar.Value = Card.Solar;
            _type.Text = Card.Type;
            _description.Text = Card.Description;

            if (Card.Visible)
            {
                button6.Text = "Убрать с продажи";
            }
            else
            {
                button6.Text = "Выставить на продажу";
            }

            if (Card.OwnerId == UserId)
            {
                button4.Visible = false;
            }
            else
            {
                button5.Visible = false;
                button6.Visible = false;
            }

            textBox1.ReadOnly = true;
            _solar.ReadOnly = true;
            _type.Enabled = false;
            _description.ReadOnly = true;

            if (!Card.Like.Contains(UserId))
            {
                button3.BackColor = Color.White;
            }
            else
            {
                button3.BackColor = Color.Red;
            }
        }

        // Приобретение помещения
        private void button4_Click(object sender, EventArgs e)
        {
            // Показываем диалоговое окно для подтверждения покупки
            DialogResult result = MessageBox.Show("Вы уверены, что хотите приобрести?", "Подтверждение покупки", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Устанавливаем текущего пользователя как владельца помещения
                Card.OwnerId = UserId;
                // Отключаем видимость что бы помещение было видно только у владельца
                Card.Visible = false;
                // Обновляем информацию о посте в базе данных
                globalManager.Post.UpdatePost(Card.Id, Card);
                DialogResult = DialogResult.OK;
            }
        }

        // Режим редактирования
        private void button5_Click(object sender, EventArgs e)
        {
            if (readMode == true)
            {
                // Переключаемся в режим редактирования
                button5.Text = "Изменить";
                readMode = false;
                textBox1.ReadOnly = true;
                _solar.ReadOnly = true;
                _type.Enabled = false;
                _description.ReadOnly = true;
            }
            if (readMode == false)
            {
                // Переключаемся в режим сохранения изменений
                button5.Text = "Сохранить";
                readMode = false;
                textBox1.ReadOnly = false;
                _solar.ReadOnly = false;
                _type.Enabled = true;
                _description.ReadOnly = false;

                // Обновляем данные объекта Card на основе введенных значений
                Card.Title = textBox1.Text;
                Card.Solar = (int)_solar.Value;
                Card.Type = _type.Text;
                Card.Description = _description.Text;
                // Обновляем информацию о посте в базе данных
                globalManager.Post.UpdatePost(Card.Id, Card);
            }
        }

        // Выставить или убрать с продажи
        private void button6_Click(object sender, EventArgs e)
        {
            if (Card.Visible)
            {
                // Если пост был видимым, то скрываем его
                Card.Visible = false;
            }
            else
            {
                // Если пост был скрытым, то делаем его видимым
                Card.Visible = true;
            }

            // Обновляем информацию о посте в базе данных
            globalManager.Post.UpdatePost(Card.Id, Card);
            DialogResult = DialogResult.OK;
        }

        // Лайк
        private void button3_Click(object sender, EventArgs e)
        {
            if (!Card.Like.Contains(UserId))
            {
                // Если пользователь еще не поставил лайк, то добавляем его
                button3.BackColor = Color.Red;
                Card.Like.Add(UserId);
                // Обновляем информацию о посте в базе данных
                globalManager.Post.UpdatePost(Card.Id, Card);
            }
            else
            {
                // Если пользователь уже поставил лайк, то удаляем его
                button3.BackColor = Color.White;
                Card.Like.Remove(UserId);
                // Обновляем информацию о посте в базе данных
                globalManager.Post.UpdatePost(Card.Id, Card);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Переключение на следующее изображение
            imagePointer = (imagePointer + 1) % Card.Images.Count;
            pictureBox1.Image = ByteToImage(globalManager.Image.GetImageById(Card.Images[imagePointer]));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Переключение на предыдущее изображение
            imagePointer = (imagePointer - 1 + Card.Images.Count) % Card.Images.Count;
            pictureBox1.Image = ByteToImage(globalManager.Image.GetImageById(Card.Images[imagePointer]));
        }

        private void ViewCard_Load(object sender, EventArgs e)
        {

        }
    }
}
