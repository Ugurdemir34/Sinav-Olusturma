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
using Sinav_Olusturma.Entities.Concrete;
using Sinav_Olusturma.Business.Abstract;
using Sinav_Olusturma.Entities.Dtos;

namespace Sinav_Olusturma.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {

        private IStoryService _storyService;
        private IQuestionService _questionService;
        public HomeController(IStoryService storyService, IQuestionService questionService)
        {
            _storyService = storyService;
            _questionService = questionService;
        }

        public IActionResult Index()
        {
            var model = new NewQuestionModel()
            {
                StoryTitles = LoadStories()
            };
            return View(model);
        }
        [HttpPost]
        public IActionResult Index(NewQuestionModel model)
        {
            var storyaddDto = new StoryAddDto()
            {
                Description = DateTime.Now.ToString(),
                Link = model.StoryLink,
                Title = model.StoryTitle,
            };
            _storyService.Add(storyaddDto);

            ViewData["message"] = "Sınav Başarıyla Oluşturuldu !";
            var lastindex = _storyService.LastIndex(storyaddDto);
            var question1 = new QuestionAddDto()
            {
                StoryId = lastindex,
                CorrectOption = model.Question1.CorrectOption,
                OptionA = model.Question1.OptionA,
                OptionB = model.Question1.OptionB,
                OptionC = model.Question1.OptionC,
                OptionD = model.Question1.OptionD,
                Title = model.Question1.Title
            };
            var question2 = new QuestionAddDto()
            {
                StoryId = lastindex,
                CorrectOption = model.Question2.CorrectOption,
                OptionA = model.Question2.OptionA,
                OptionB = model.Question2.OptionB,
                OptionC = model.Question2.OptionC,
                OptionD = model.Question2.OptionD,
                Title = model.Question2.Title
            };
            var question3 = new QuestionAddDto()
            {
                StoryId = lastindex,
                CorrectOption = model.Question3.CorrectOption,
                OptionA = model.Question3.OptionA,
                OptionB = model.Question3.OptionB,
                OptionC = model.Question3.OptionC,
                OptionD = model.Question3.OptionD,
                Title = model.Question3.Title
            };
            var question4 = new QuestionAddDto()
            {
                StoryId = lastindex,
                CorrectOption = model.Question4.CorrectOption,
                OptionA = model.Question4.OptionA,
                OptionB = model.Question4.OptionB,
                OptionC = model.Question4.OptionC,
                OptionD = model.Question4.OptionD,
                Title = model.Question4.Title
            };

            _questionService.Add(question1);
            _questionService.Add(question2);
            _questionService.Add(question3);
            _questionService.Add(question4);
            return RedirectToAction("Index");
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
                                                Value = a.Link,
                                                Text = a.Title,

                                            }).ToList();
            return stories;
        }
        public IActionResult List()
        {
            var model = _storyService.GetAll();
            return View(model);
        }
        public JsonResult DeleteStory(int storyId)
        {
            var story = _storyService.GetById(storyId);
            _storyService.Delete(story);
            return Json("1");
        }

    }
}
