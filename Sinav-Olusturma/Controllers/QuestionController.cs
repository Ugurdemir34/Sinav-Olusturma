using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Sinav_Olusturma.Controllers
{
    public class QuestionController : Controller
    {
        public IActionResult Index(string url)
        {
            ViewData["link"] = url;
            return View();
        }
    }
}
