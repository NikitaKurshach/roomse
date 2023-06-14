using Lib;
using Lib.Models;
using NRoomS.controller;
using Roommse;
using System.Reflection;
namespace NRoomS
{
    public partial class MainWindow : Form
    {
        // Объявление переменных и объектов

        string mode = "Главная"; // Режим работы окна по умолчанию
        string url = "mongodb+srv://bart00alen:Qw3yYrZuHBcX8eMr@cluster0.trhsqcc.mongodb.net/?retryWrites=true&w=majority"; // URL для подключения к базе данных MongoDB
        List<string> tags = new List<string>(); // Список тегов для фильтрации
        string? city; // Выбранный город для фильтрации
        GlobalManager globalManager; // Глобальный менеджер для работы с базой данных MongoDB
        Lib.Models.User user; // Текущий пользователь
        List<Lib.Models.Post> posts = new(); // Список объявлений

        public MainWindow()
        {
            // Инициализация глобального менеджера и аутентификация пользователя

            globalManager = new GlobalManager(
            url,
            "rooms");

            if (new IniFileManager("data.ini").FileExists())
            {
                var (login, password) = new IniFileManager("data.ini").GetCredentials();
                var results = globalManager.User.Login(login, password);
                if (results)
                {
                    user = globalManager.User.GetUser(login, password);
                    InitializeComponent();
                }
                else
                {
                    var auth = new Authentication(url, globalManager);
                    var result = auth.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        InitializeComponent();
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        Environment.Exit(0);
                    }
                }
            }
            else
            {
                var auth = new Authentication(url, globalManager);
                var result = auth.ShowDialog();
                if (result == DialogResult.OK)
                {
                    InitializeComponent();
                }
                else if (result == DialogResult.Cancel)
                {
                    Environment.Exit(0);
                }

                user = auth.user;
            }

            _user_panel.setUser(user.Login);
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            // Настройка элементов управления при загрузке окна

            var new_post = Clone(_baseBTN);
            new_post.Text = "Выставить объявление";
            new_post.Visible = true;
            new_post.Click += (e, s) =>
            {
                new RoomConfigure(user.Id, globalManager).ShowDialog();
                UpdateView();
            };

            _baseBTN.Visible = false;
            var home_btn = Clone(_baseBTN);
            home_btn.Text = "Главная";
            home_btn.Visible = true;
            home_btn.Click += (e, s) =>
            {
                mode = "Главная";
                UpdateView();
            };
            var my_obv_btn = Clone(_baseBTN);
            my_obv_btn.Text = "Мои помещения";
            my_obv_btn.Visible = true;
            my_obv_btn.Click += (e, s) =>
            {
                mode = "Мои помещения";
                UpdateView();
            };

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Обновление списка объявлений

            var db_posts = globalManager.Post.GetAll();

            if (db_posts.Count != posts.Count)
            {
                posts = db_posts;

                foreach (var item in posts)
                {
                    if (!comboBox1.Items.Contains(item.City))
                    {
                        comboBox1.Items.Add(item.City);
                    }
                    foreach (var item1 in item.Tags)
                    {
                        if (!_tags_box.Items.Contains(item1))
                        {
                            _tags_box.Items.Add(item1);
                        }
                    }
                }

                UpdateView();
            }
            else
            {
                for (int i = 0; i < db_posts.Count; i++)
                {
                    if (cardAnd(posts[i], db_posts[i]))
                    {

                    }
                    else
                    {
                        posts = db_posts;

                        foreach (var item in posts)
                        {
                            if (!comboBox1.Items.Contains(item.City))
                            {
                                comboBox1.Items.Add(item.City);
                            }
                            foreach (var item1 in item.Tags)
                            {
                                if (!_tags_box.Items.Contains(item1))
                                {
                                    _tags_box.Items.Add(item1);
                                }
                            }
                        }

                        UpdateView();
                    }
                }
            }

        }

        private bool cardAnd(Post post, Post post1)
        {
            // Сравнение двух объявлений

            if (post.Id != post1.Id)
            {
                return false;
            }
            if (post.Type != post1.Type)
            {
                return false;
            }
            if (post.Title != post1.Title)
            {
                return false;
            }
            if (post.Visible != post1.Visible)
            {
                return false;
            }
            if (post.Solar != post1.Solar)
            {
                return false;
            }
            if (!post.Like.SequenceEqual(post1.Like))
            {
                return false;
            }
            return true;
        }

        private void UpdateView()
        {
            // Обновление представления списка объявлений

            _card_panel.Controls.Clear();
            foreach (var item in posts)
            {
                if (mode == "Мои помещения")
                {
                    if (item.OwnerId != user.Id)
                    {
                        continue;
                    }
                }
                else
                {
                    if (!item.Visible)
                    {
                        continue;
                    };
                }
                var tag = true;
                if (city != null)
                    if (city != "Все")
                        if (item.City != city)
                            continue;
                if (tags.Count != 0)
                {
                    tag = false;
                    foreach (string item1 in tags)
                    {
                        if (item.Tags.Contains(item1))
                        {
                            tag = true;
                        }
                    }
                }
                if (tag)
                {
                    var nev_card = new UICard(item.Id, globalManager, user.Id);
                    nev_card.Tag = item.Id;
                    _card_panel.Controls.Add(nev_card);

                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Обработка изменения выбранного города в комбо-боксе

            city = comboBox1.SelectedItem.ToString();
            UpdateView();
        }

        private void _tags_box_SelectedIndexChanged(object sender, MouseEventArgs e)
        {
            // Обработка изменения выбранных тегов в списке

            var loctags = new List<string>();
            foreach (string item in _tags_box.CheckedItems)
            {
                loctags.Add(item);
            }
            if (!loctags.SequenceEqual(tags))
            {
                tags = loctags;
                UpdateView();
            }

        }

        public static T Clone<T>(T controlToClone) where T : Control
        {
            // Создание копии элемента управления

            T instance = Activator.CreateInstance<T>();

            Type control = controlToClone.GetType();
            PropertyInfo[] info = control.GetProperties();
            object p = control.InvokeMember("", System.Reflection.BindingFlags.CreateInstance, null, controlToClone, null);
            foreach (PropertyInfo pi in info)
            {
                if ((pi.CanWrite) && !(pi.Name == "WindowTarget") && !(pi.Name == "Capture"))
                {
                    pi.SetValue(instance, pi.GetValue(controlToClone, null), null);
                }
            }
            return instance;
        }
    }
}
