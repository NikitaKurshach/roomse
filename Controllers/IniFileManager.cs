namespace NRoomS.controller
{
    public class IniFileManager
    {
        private string filePath;

        public IniFileManager(string filePath)
        {
            this.filePath = filePath;
        }

        public bool FileExists()
        {
            // Проверяет, существует ли файл с указанным путем
            return File.Exists(filePath);
        }

        public void SaveCredentials(string login, string password)
        {
            // Создает список строк, содержащих логин и пароль
            List<string> lines = new List<string>
            {
                $"login={login}",
                $"password={password}"
            };

            // Записывает список строк в файл с указанным путем
            File.WriteAllLines(filePath, lines);
        }

        public (string login, string password) GetCredentials()
        {
            if (!FileExists())
            {
                throw new FileNotFoundException("INI file not found.");
            }

            // Считывает все строки из файла с указанным путем
            var lines = File.ReadAllLines(filePath);

            // Преобразует строки в словарь ключ-значение, разделяя их по символу "="
            var credentials = lines.Select(line => line.Split('=')).ToDictionary(parts => parts[0], parts => parts[1]);

            // Получает логин и пароль из словаря
            if (credentials.TryGetValue("login", out string login) && credentials.TryGetValue("password", out string password))
            {
                return (login, password);
            }

            throw new InvalidDataException("Invalid INI file format.");
        }

        public void DeleteFile()
        {
            // Удаляет файл с указанным путем, если он существует
            if (FileExists())
            {
                File.Delete(filePath);
            }
        }
    }
}
