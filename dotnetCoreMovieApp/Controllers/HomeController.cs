using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dotnetCoreMovieApp.Models;

namespace dotnetCoreMovieApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(int? id)
        {
            //Repository.Movies
            //Category ComponentView

            var movies = Repository.Movies;
            if (id != null)
            {
                movies = movies.Where(x => x.CategoryId == id).ToList();
            }

            return View(movies);
        }
        public IActionResult Details(int id)
        {
            return View(Repository.GetById(id));
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
