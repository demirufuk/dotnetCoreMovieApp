using dotnetCoreMovieApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetCoreMovieApp.ViewComponents
{
    public class CategoryMenuViewComponent:ViewComponent
    {
        //a active class
        //{controller}/{action}/{id?}
        //Route.Values["controller"] => home

        public IViewComponentResult Invoke()
        {
            if(RouteData.Values["action"].ToString()=="Index")
                ViewBag.SelectedCategory = RouteData?.Values["id"];


            return View(CategoryRepository.Categories);
        }
    }
}
