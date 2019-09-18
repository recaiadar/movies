using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using MongoDB.Driver;
using Movies.Models;

namespace Movies.Controllers
{
    public class MovieController : Controller
    {
        private readonly IMongoClient _mongoClient;
        private readonly IMongoDatabase _mongoDatabase;
        public MovieController(MongoClient mongoClient)
        {
            _mongoClient = mongoClient;
            _mongoDatabase = _mongoClient.GetDatabase("movie");
        }
        public IActionResult Index()
        {
            var movieDetails = _mongoDatabase.GetCollection<Movie>("movie").Find(new BsonDocument()).ToList();
            return View(movieDetails);
        }

        public ActionResult Details(string id)
        {
            var filter = Builders<Movie>.Filter.Eq("Id", id);
            var movie = _mongoDatabase.GetCollection<Movie>("movie").Find(filter).First();
            return View(movie);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Movie movie)
        {
            try
            {
                var collection = _mongoDatabase.GetCollection<Movie>("movie");
                var filter = Builders<Movie>.Filter.Eq("Title", movie.Title) & Builders<Movie>.Filter.Eq("Director", movie.Director);
                
                var collectionCount = collection.CountDocuments(filter);
                
                if (collectionCount == 0)
                {
                    collection.InsertOne(movie);
                }
                else
                {
                    TempData["Message"] = "Movie already exists";
                    return View("Create", movie);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        [HttpGet]
        public ActionResult Edit(string id)
        {
            var collection = _mongoDatabase.GetCollection<Movie>("movie");
            var filter = Builders<Movie>.Filter.Eq("Id", id);

            var collectionCount = collection.CountDocuments(filter);

            if (collectionCount > 0)
            {
                var movieDetail = _mongoDatabase.GetCollection<Movie>("movie").Find(filter).First();
                return View(movieDetail);
            }
            return RedirectToAction(nameof(Index));
        }
        
        [HttpPost]
        public ActionResult Edit(string id, Movie movie)
        {
            try
            {
                var collection = _mongoDatabase.GetCollection<Movie>("movie");
                var filter = Builders<Movie>.Filter.Eq("Id", id);

                collection.ReplaceOne(
                    filter,
                    movie, 
                    new UpdateOptions { IsUpsert = true });

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        [HttpGet]
        public ActionResult Delete(string id)
        {
            var filter = Builders<Movie>.Filter.Eq("Id", id);
            var movie = _mongoDatabase.GetCollection<Movie>("movie").Find(filter).First();
            return View(movie);
        }
        
        [HttpPost]
        public ActionResult Delete(string id, Movie movie)
        {
            try
            {
                var filter = Builders<Movie>.Filter.Eq("Id", id);
                var collection = _mongoDatabase.GetCollection<Movie>("movie");
                collection.DeleteOne(filter);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
