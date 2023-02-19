using FilmCollection.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FilmCollection.Controllers
{
    public class HomeController : Controller
    {
        private FilmCollectionContext FilmContext { get; set; }

        public HomeController(FilmCollectionContext movie)
        {
            FilmContext = movie;
        }

        public IActionResult Index()
        {
            return View();
        }

    

        [HttpGet]
        public IActionResult Movies()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Movies(MoviesResponse mr)
        {
            if (ModelState.IsValid)
            {
                FilmContext.Add(mr);
                FilmContext.SaveChanges();

                return View("Confirmation", mr);
            }
            else
            {
                return View();
            }
        }

        public IActionResult Confirmation()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult MovieList()
        {
            //maybe needs to be Responses?
            var moviesList = FilmContext.responses
                .OrderBy(x => x.Category)
                .ToList();

            return View(moviesList);
        }
    }
}
