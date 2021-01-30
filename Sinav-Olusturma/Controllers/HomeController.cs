using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Sinav_Olusturma.Models;
using Sinav_Olusturma.Helper;
using Sinav_Olusturma.DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Sinav_Olusturma.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
      
    
        public HomeController()
        {
           
        }

        public IActionResult Index()
        {
            var model = new NewQuestionModel()
            {
                StoryTitles = LoadStories()
            };
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        private List<SelectListItem> LoadStories()
        {
            List<SelectListItem> stories = (from a in RssReader.GetStories()
                                            select new SelectListItem
                                            {
                                                Value = a.Title,
                                                Text = a.Title
                                            }).ToList();
            return stories;
        }

      
    }
}
