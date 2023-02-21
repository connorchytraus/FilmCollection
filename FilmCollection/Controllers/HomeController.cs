using FilmCollection.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            ViewBag.CateogriesX = FilmContext.Categories.ToList();

            return View("Movies", new MoviesResponse());
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
                ViewBag.CateogriesX = FilmContext.Categories.ToList();

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
            var moviesList = FilmContext.responses
                .Include(x => x.Category)
                .OrderBy(x => x.Category)
                .ToList();

            return View(moviesList);
        }

        [HttpGet]
        public IActionResult Edit(int movieid)
        {
            ViewBag.CategoriesX = FilmContext.Categories.ToList();

            var movie = FilmContext.responses.Single(x => x.MovieId == movieid);

            return View("Movies", movie);
        }

        [HttpPost]
        public IActionResult Edit(MoviesResponse movie)
        {
            FilmContext.Update(movie);
            FilmContext.SaveChanges();

            return RedirectToAction("MovieList");
        }

        [HttpGet]
        public IActionResult Delete(int movieid)
        {
            var movie = FilmContext.responses.Single(x => x.MovieId == movieid);
            return View(movie);
        }

        [HttpPost]
        public IActionResult Delete(MoviesResponse mr)
        {
            FilmContext.responses.Remove(mr);
            FilmContext.SaveChanges();

            return RedirectToAction("MovieList");
        }
    }
}
