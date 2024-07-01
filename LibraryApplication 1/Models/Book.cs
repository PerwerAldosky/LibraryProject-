using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace LibraryApplication_1.Models
{
    public class Book
    {
       
        public ObjectId Id { get; set; }
        public string Title { get; set; }
        public int Pages { get; set; }
        


    }
}
