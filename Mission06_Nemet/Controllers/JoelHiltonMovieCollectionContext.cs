using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission06_Nemet.Models;
using static System.Net.Mime.MediaTypeNames;

namespace Mission06_Nemet.Controllers
{
    public class JoelHiltonMovieCollectionContext : Controller
    {
        private readonly Models.MovieDbContext _context;
        public JoelHiltonMovieCollectionContext(Models.MovieDbContext context)
        {
            _context = context;
        }

        // Default action for the Index page
        public IActionResult Index()
        {
            return View();
        }

        // Action for the About (Get to Know Joel) page
        public IActionResult GetToKnowJoel()
        {
            return View();
        }

        // Action for rendering the movie entry form (GET)
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // Action to handle form submission (POST)
        [HttpPost]
        public IActionResult Create(Movie response)
        {
            // Save the movie in the database
            _context.Movies.Add(response); // Use Movies instead of Application
            _context.SaveChanges(); // Save changes to the database

            // Redirect to a confirmation page after adding the movie
            return View("Confirmation", response);
        }
    }
}

