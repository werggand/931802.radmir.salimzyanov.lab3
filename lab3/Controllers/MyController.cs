using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using lab3.Models;

namespace lab3.Controllers
{
    public class MyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult QuizView()
        {
            return View(new MyModelQuiz());
        }

        [HttpPost]
        public IActionResult QuizView(MyModelQuiz operation, string action)
        {
            if (ModelState.IsValid)
            {
                if (operation.Check())
                    MyModelAnswer.Instance.correct++;
                MyModelAnswer.Instance.answers.Add(operation);
            }
            else
            {
                ModelState.AddModelError("YourAnswer", "недопустимый формат ответа");
                return View(operation);
            }
            if (action == "Next")
                return View(new MyModelQuiz());

            return RedirectToAction("AnswerView");
        }
        public IActionResult AnswerView()
        {
            return View(MyModelAnswer.Instance);
        }
    }
}
