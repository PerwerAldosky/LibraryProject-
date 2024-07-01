using MongoDB.Driver;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using LibraryApplication_1.Models;
using MongoDB.Bson;


namespace LibraryApplication_1.Controllers
{
    public class BooksController : Controller
    {

        public IActionResult Index()
        {

            {
                MongoClient dbClient = new MongoClient();

                var database = dbClient.GetDatabase("Library_application");
                var collection = database.GetCollection<Book>("books");
                List<Book> books = collection.Find(b => true).ToList();

                return View(books);


            }

        }

        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(Book book)
        {

            MongoClient dbClient = new MongoClient();

            var database = dbClient.GetDatabase("Library_application");
            var collection = database.GetCollection<Book>("books");
            collection.InsertOne(book);



            return Redirect("/Books");
        }

        public IActionResult Show(string Id)
        {
           
            ObjectId bookId = new ObjectId(Id);
            MongoClient dbClient = new MongoClient();

            var database = dbClient.GetDatabase("Library_application");
            var collection = database.GetCollection<Book>("books");

            Book book = collection.Find(b => b.Id == bookId).FirstOrDefault();

            return View(book);
        }

    }


}

