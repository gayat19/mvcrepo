using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstWepApplication.Models;

namespace FirstWepApplication.Controllers
{
    public class MovieController : Controller
    {
        //http://localhost:2234/Movie/Index
        // GET: Movie
        public ActionResult Index()
        {
            ViewBag.city = "MyCity";
            ViewBag.name = "Ramu";

            ViewData["price"] = 120.23;
            return  View();
        }


        public ActionResult ShowModel()
        {
            Movie movie = new Movie(101, "A-Team", 123.3f);
            ViewBag.myMovie = movie;
            return View();
        }

        public ActionResult ModelInView()
        {
            Movie movie = new Movie(101, "A-Team", 123.3f);
            return View(movie);
        }

        public ActionResult AllMovies()
        {
            List<Movie> movies = new List<Movie>();
            movies.Add(new Movie(101, "A-Team", 123.3f));
            movies.Add(new Movie(102, "Doctor Strange", 102.5f));
            movies.Add(new Movie(103, "Harry Potter 1", 110.7f));
            return View(movies);
        }


        public ActionResult Details()
        {
            string[] names = { "Ramu", "Bimu", "Somu" };
            //ViewData["usernames"] = names;
            ViewBag.usernames = names;
            return View();
        }
    }
}