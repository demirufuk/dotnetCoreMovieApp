using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnetCoreMovieApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnetCoreMovieApp.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult List()
        {
            return View();
        }

        public IActionResult Details()
        {
            return View();
        }
    }
}