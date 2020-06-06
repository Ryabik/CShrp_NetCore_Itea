using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Homework3.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewEngines;

namespace Homework3.Controllers
{
    public class NewsController : Controller
    {
        private readonly INewsRepository  _newsRepository;  
        public NewsController(INewsRepository newsRepository)
        {
            _newsRepository = newsRepository;
        }
            
        //[Route ("News/Index/{?Id}")]
        public ViewResult Index()
        {

            var model = _newsRepository.GetAllNews();
            return View(model);
        }

        public IActionResult Show(int id)
        {
            News model = _newsRepository.GetArticle(id);
            ViewData["HeadTitle"] = model.Title;
            ViewData["Article"] = model;
            return View();
        }
    }
}