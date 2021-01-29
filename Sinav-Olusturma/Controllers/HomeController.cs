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

namespace Sinav_Olusturma.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
      
    
        public HomeController(ILogger<HomeController> logger)
        {
           
        }

        public IActionResult Index()
        {
            var model =RssReader.GetStories();
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

      
    }
}
