using Lib;
using NRoomS.controller;

namespace NRoomS
{
    public partial class Authentication : Form
    {
        private GlobalManager globalManager;
        public Lib.Models.User user;

        public Authentication(string url, GlobalManager globalManager)
        {
            InitializeComponent();
            this.globalManager = globalManager;
        }

        private void _auth_button_Click(object sender, EventArgs e)
        {
            // Получаем логин и пароль из текстовых полей
            var login = _auth_login.Text;
            var password = _auth_password.Text;

            // Вызываем метод Login у объекта globalManager.User для проверки аутентификации
            var result = globalManager.User.Login(login, password);

            // Если результат равен false, выводим сообщение о неверном логине или пароле
            if (!result)
            {
                MessageBox.Show("Неверный логин или пароль");
                return;
            }

            // Если флажок _saveUser отмечен, сохраняем учетные данные в ini-файл
            if (_saveUser.Checked)
            {
                new IniFileManager("data.ini").SaveCredentials(login, password);
            }

            // Получаем объект пользователя с помощью метода GetUser у объекта globalManager.User
            user = globalManager.User.GetUser(login, password);

            // Устанавливаем результат окна аутентификации на DialogResult.OK
            DialogResult = DialogResult.OK;
        }

        private void _reg_button_Click(object sender, EventArgs e)
        {
            // Получаем логин и пароль из текстовых полей
            var login = _reg_login.Text;
            var password = _reg_password1.Text;

            // Проверяем условия для регистрации пользователя
            if (login.Length < 3)
            {
                MessageBox.Show("Слишком короткий логин");
                return;
            }
            else if (password.Length < 8)
            {
                MessageBox.Show("Слишком слабый пароль");
                return;
            }
            else if (password != _reg_password2.Text)
            {
                MessageBox.Show("Пароли не совпадают");
                return;
            }
            else if (globalManager.User.IsRegistered(login))
            {
                MessageBox.Show("Пользователь уже существует");
                return;
            }

            // Вызываем метод Register у объекта globalManager.User для регистрации пользователя
            var result = globalManager.User.Register(login, password);

            if (result)
            {
                // Если регистрация успешна и флажок _saveUser отмечен, сохраняем учетные данные в ini-файл
                if (_saveUser.Checked)
                {
                    new IniFileManager("data.ini").SaveCredentials(login, password);
                }

                // Получаем объект пользователя с помощью метода GetUser у объекта globalManager.User
                user = globalManager.User.GetUser(login, password);

                // Устанавливаем результат окна аутентификации на DialogResult.OK
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Ошибка регистрации. Попробуйте чуть позже.");
            }
        }

        private void Authentication_Load(object sender, EventArgs e)
        {

        }
    }
}
