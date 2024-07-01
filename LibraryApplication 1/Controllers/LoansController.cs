using LibraryApplication_1.Models;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

namespace LibraryApplication_1.Controllers
{
    public class LoansController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
                        
        public IActionResult Create()
        {
            MongoClient dbClient = new MongoClient();

            var database = dbClient.GetDatabase("Library_application");
            var collection = database.GetCollection<Book>("books");
            List<Book> books = collection.Find(b => true).ToList();

            return View(books);

        }

        [HttpPost]
        public IActionResult Create(Loan loan) 
        {

            MongoClient dbClient = new MongoClient();

            var database = dbClient.GetDatabase("Library_application");
            var collection = database.GetCollection<Loan>("Loan");
            collection.InsertOne(loan);



            return Redirect("/Books");
        }
    }
}
