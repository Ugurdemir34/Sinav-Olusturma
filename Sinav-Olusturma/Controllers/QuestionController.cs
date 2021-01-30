using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sinav_Olusturma.Entities.Concrete;
using Sinav_Olusturma.Helper;

namespace Sinav_Olusturma.Controllers
{
    public class QuestionController : Controller
    {
        
        public IActionResult Index(string storyLink,string storyTitle)
        {
            ViewData["storyLink"] = storyLink;
            ViewData["storyTitle"] = storyTitle;
            TempData["stories"] = RssReader.GetStories();
            return View();
        }
        
    }
}
