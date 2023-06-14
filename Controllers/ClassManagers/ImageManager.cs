using MongoDB.Bson;


namespace NRoomS.controller.ClassManagers
{
    public class ImageManager
    {
        private MongoDBManager dbManager;

        public ImageManager(string connectionString, string databaseName, string collectionName)
        {
            // Создаем экземпляр MongoDBManager для работы с базой данных
            dbManager = new MongoDBManager(connectionString, databaseName, collectionName);
        }

        public ImageManager(string connectionString, string databaseName)
        {
            // Создаем экземпляр MongoDBManager для работы с базой данных,
            // используя имя коллекции по умолчанию "images"
            dbManager = new MongoDBManager(connectionString, databaseName, "images");
        }

        public string AddImage(string imagePath)
        {
            // Генерируем новый уникальный идентификатор для изображения
            ObjectId imageId = ObjectId.GenerateNewId();

            // Создаем документ BSON, содержащий идентификатор и байты изображения
            BsonDocument imageDocument = new BsonDocument
            {
                { "_id", imageId },
                { "image", GetImageBytes(imagePath) }
            };

            // Вставляем документ в базу данных
            dbManager.InsertDocument(imageDocument);

            // Возвращаем строковое представление идентификатора изображения
            return imageId.ToString();
        }

        public MemoryStream GetImageById(string id)
        {
            // Получаем документ изображения по указанному идентификатору
            BsonDocument imageDocument = dbManager.GetDocumentById(id);

            // Проверяем, что документ существует и содержит поле "image"
            if (imageDocument != null && imageDocument.Contains("image"))
            {
                // Извлекаем байты изображения из документа и создаем поток памяти
                byte[] imageBytes = imageDocument["image"].AsByteArray;
                return new MemoryStream(imageBytes);
            }

            // Возвращаем null, если документ не найден или не содержит изображения
            return null;
        }

        private byte[] GetImageBytes(string imagePath)
        {
            // Читаем байты изображения из файла
            return File.ReadAllBytes(imagePath);
        }
    }
}
