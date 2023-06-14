using NRoomS.controller.ClassManagers;
using Lib.Models;
using MongoDB.Bson;

namespace NRoomS.controller.ClassManagers
{
    public class UserManager
    {
        private MongoDBManager mongoDBManager;

        public UserManager(string connector, string database, string collection)
        {
            // Инициализация объекта MongoDBManager для работы с базой данных MongoDB
            mongoDBManager = new MongoDBManager(connector, database, collection);
        }

        public UserManager(string connector, string database)
        {
            // Инициализация объекта MongoDBManager для работы с базой данных MongoDB,
            // с указанием коллекции "User" по умолчанию
            mongoDBManager = new MongoDBManager(connector, database, "User");
        }

        // Метод для создания MD5-хэша из входной строки
        public static string CreateMD5(string input)
        {
            // Используем входную строку для вычисления MD5-хэша
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);
                return Convert.ToHexString(hashBytes);
            }
        }

        // Метод для регистрации пользователя
        public bool Register(string login, string password)
        {
            // Получение документа из базы данных по полю "Login"
            var data = mongoDBManager.GetDocumentByField("Login", login);

            if (data == null)
            {
                // Создание объекта User с указанными значениями
                var user = new User
                {
                    Login = login,
                    Password = CreateMD5(password)
                };

                // Вставка документа в базу данных
                mongoDBManager.InsertDocument(user.ToBsonDocument());
                return true;
            }
            else
            {
                return false;
            }
        }

        // Метод для выполнения входа пользователя
        public bool Login(string login, string password)
        {
            // Получение документа из базы данных по полю "Login"
            var data = mongoDBManager.GetDocumentByField("Login", login);

            if (data != null)
            {
                // Проверка соответствия пароля хэшу MD5
                if (data["Password"] == CreateMD5(password))
                    return true;
                return false;
            }
            else
            {
                return false;
            }
        }

        // Метод для получения объекта пользователя
        public User GetUser(string login, string password)
        {
            // Получение документа из базы данных по полю "Login"
            var data = mongoDBManager.GetDocumentByField("Login", login);

            if (data != null)
            {
                // Проверка соответствия пароля хэшу MD5
                if (data["Password"] == CreateMD5(password))
                {
                    // Создание объекта User с указанными значениями
                    var user = new User
                    {
                        Id = data["_id"].ToString(),
                        Login = data["Login"].ToString(),
                        Password = data["Password"].ToString()
                    };

                    return user;
                }

                return null;
            }
            else
            {
                return null;
            }
        }

        // Метод для проверки, зарегистрирован ли пользователь
        public bool IsRegistered(string login)
        {
            // Получение документа из базы данных по полю "Login"
            var data = mongoDBManager.GetDocumentByField("Login", login);

            if (data == null)
            {
                return false;
            }
            return true;
        }
    }
}
