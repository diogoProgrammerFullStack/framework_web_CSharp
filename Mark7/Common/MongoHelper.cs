using MongoDB.Bson;
using MongoDB.Driver;
using System.Configuration;

namespace Mark7.Common
{
    public class MongoHelper
    {
        //Exemplo:
        //"mongodb://usuario:senha@servidor:porta/banco"

        //Dados Banco
        //*Host => ds225078.mlab.com
        //* Port => 25078
        //* Database => heroku_4m3km28x
        //* User => heroku_4m3km28x
        //* Pass => rmrm93njviet46a4caul3svj4p

        private IMongoDatabase _database;

        public MongoHelper()
        {
            string strConn = ConfigurationManager.AppSettings["MongoStrConn"];
            var client = new MongoClient(strConn);
            _database = client.GetDatabase(ConfigurationManager.AppSettings["MongoDataBase"]);
        }

        public IMongoCollection<BsonDocument> Collection(string collection)
        {
            return _database.GetCollection<BsonDocument>(collection);
        }

        public void DeleteByTitle(string titulo)
        {
            var filter = Builders<BsonDocument>.Filter.Gte("title", titulo);

            Collection("tasks").DeleteMany(filter);
        }
    }
}
