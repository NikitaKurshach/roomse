using Lib.Models;
using MongoDB.Bson;

namespace NRoomS.controller.ClassManagers
{
    public class PostManager
    {
        private MongoDBManager mongoDBManager;

        public PostManager(string connector, string database, string collection)
        {
            // Создание экземпляра MongoDBManager с переданными параметрами
            mongoDBManager = new MongoDBManager(connector, database, collection);
        }

        public PostManager(string connector, string database)
        {
            // Создание экземпляра MongoDBManager с переданными параметрами, используя коллекцию "User" по умолчанию
            mongoDBManager = new MongoDBManager(connector, database, "User");
        }

        public bool CreatePost(Post post)
        {
            var data = mongoDBManager.GetDocumentByField("title", post.Title);

            if (data == null)
            {
                // Создание нового документа BsonDocument с данными из объекта post
                var document = new BsonDocument
                {
                    { "title", post.Title },                    // Заголовок поста
                    { "description", post.Description },        // Описание поста
                    { "type", post.Type },                      // Тип поста
                    { "city", post.City },                      // Город
                    { "address", post.Address },                // Адрес
                    { "create_at", post.CreatedAt },            // Дата создания
                    { "owner_id", post.OwnerId },               // Идентификатор владельца
                    { "visible", post.Visible },                // Флаг видимости
                    { "solar", post.Solar },                    // Количество лайков
                    { "images", new BsonArray(post.Images) },   // Коллекция изображений
                    { "tags", new BsonArray(post.Tags) },       // Коллекция тегов
                    { "like", new BsonArray(post.Like) }        // Коллекция лайков
                };

                // Вставка документа в базу данных
                mongoDBManager.InsertDocument(document);
                return true;
            }
            else
            {
                // Если пост с таким заголовком уже существует, вернуть false
                return false;
            }
        }

        public bool UpdatePost(string postId, Post post)
        {
            var data = mongoDBManager.GetDocumentById(postId);

            if (data != null)
            {
                // Создание нового документа BsonDocument с обновленными данными из объекта post
                var document = new BsonDocument
                {
                    { "title", post.Title },                    // Заголовок поста
                    { "description", post.Description },        // Описание поста
                    { "type", post.Type },                      // Тип поста
                    { "city", post.City },                      // Город
                    { "address", post.Address },                // Адрес
                    { "create_at", post.CreatedAt },            // Дата создания
                    { "owner_id", post.OwnerId },               // Идентификатор владельца
                    { "visible", post.Visible },                // Флаг видимости
                    { "solar", post.Solar },                    // Количество лайков
                    { "images", new BsonArray(post.Images) },   // Коллекция изображений
                    { "tags", new BsonArray(post.Tags) },       // Коллекция тегов
                    { "like", new BsonArray(post.Like) }        // Коллекция лайков
                };

                // Обновление документа в базе данных
                mongoDBManager.UpdateDocument(postId, document);
                return true;
            }
            else
            {
                // Если пост с указанным идентификатором не найден, вернуть false
                return false;
            }
        }

        public bool DeletePost(string postId)
        {
            var data = mongoDBManager.GetDocumentById(postId);

            if (data != null)
            {
                // Удаление документа из базы данных
                mongoDBManager.DeleteDocument(postId);
                return true;
            }
            else
            {
                // Если пост с указанным идентификатором не найден, вернуть false
                return false;
            }
        }

        public List<Post> GetAll()
        {
            List<Post> posts = new List<Post>();
            var datas = mongoDBManager.GetDocuments();

            foreach (var data in datas)
            {
                var post = new Post
                {
                    Id = data.GetValue("_id").AsObjectId.ToString(),
                    Title = data.GetValue("title").AsString,
                    Description = data.GetValue("description").AsString,
                    Type = data.GetValue("type").AsString,
                    City = data.GetValue("city").AsString,
                    Address = data.GetValue("address").AsString,
                    CreatedAt = data.GetValue("create_at").AsString,
                    OwnerId = data.GetValue("owner_id").AsString,
                    Visible = data.GetValue("visible").AsBoolean,
                    Solar = data.GetValue("solar").AsInt32,
                    Images = data.GetValue("images").AsBsonArray.Select(x => x.ToString()).ToList(),
                    Tags = data.GetValue("tags").AsBsonArray.Select(x => x.ToString()).ToList(),
                    Like = data.GetValue("like").AsBsonArray.Select(x => x.ToString()).ToList()
                };
                posts.Add(post);
            }

            return posts;
        }

        public Post GetPostById(string postId)
        {
            var data = mongoDBManager.GetDocumentById(postId);

            if (data != null)
            {
                var post = new Post
                {
                    Id = postId,
                    Title = data.GetValue("title").AsString,
                    Description = data.GetValue("description").AsString,
                    Type = data.GetValue("type").AsString,
                    City = data.GetValue("city").AsString,
                    Address = data.GetValue("address").AsString,
                    CreatedAt = data.GetValue("create_at").AsString,
                    OwnerId = data.GetValue("owner_id").AsString,
                    Visible = data.GetValue("visible").AsBoolean,
                    Solar = data.GetValue("solar").AsInt32,
                    Images = data.GetValue("images").AsBsonArray.Select(x => x.ToString()).ToList(),
                    Tags = data.GetValue("tags").AsBsonArray.Select(x => x.ToString()).ToList(),
                    Like = data.GetValue("like").AsBsonArray.Select(x => x.ToString()).ToList()
                };

                return post;
            }
            else
            {
                // Если пост с указанным идентификатором не найден, вернуть null
                return null;
            }
        }
    }
}
