using Microsoft.AspNetCore.Mvc;
using SPWebApplication.Data.Services;
using SPWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPWebApplication.Controllers
{
    public class FaqController : Controller
    {
        private readonly  ILogicServices _service;
        public FaqController(ILogicServices service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var data = _service.GetAll();
            return View(data);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add([Bind("Category,Description")] FAQ fAQ)
        {
            if (!ModelState.IsValid)
            {
                return View(fAQ);
            }
            _service.Add(fAQ);
            return RedirectToAction(nameof(Index));
        }
    }
}
