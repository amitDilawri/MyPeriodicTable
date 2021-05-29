using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyPeriodicTable.Models;
using MyPeriodicTable.View_Model;

namespace MyPeriodicTable.Controllers
{
    public class QuizController : Controller
    {
        // GET: Quiz
        public ActionResult DisplayQuiz()
        {
            
            return View(new QuizProperties { questionsDictionary = QuizObjects.dictionaryOfQuestions});
        }

       
        public ActionResult QuizSelection(FormCollection form)
        {

            List<QuizQuesAndAnswers> myQuiz = new List<QuizQuesAndAnswers>();
            myQuiz.AddRange(QuizObjects.dictionaryOfQuestions.Values);

            int count = 0;
            string firstAnswer = form["Option_1"].ToString();
            string secondAnswer = form["Option_2"].ToString();
            string thirdAnswer = form["Option_3"].ToString();
            string fourthAnswer = form["Option_4"].ToString();
            string fifthAnswer = form["Option_5"].ToString();
            TempData["name"] = form["UserName"].ToString();

            if(firstAnswer == null || secondAnswer == null || thirdAnswer == null || fourthAnswer == null || fifthAnswer == null)
            {
                TempData["quizResult"] = "Please answer all questions";
            }
            else
            {
                if (firstAnswer == "Fe")
                {
                    count += 10;
                }
                if (secondAnswer == "Nitrogen")
                {
                    count += 10;
                }
                if (thirdAnswer == "Copper")
                {
                    count += 10;
                }
                if (fourthAnswer == "118")
                {
                    count += 10;
                }
                if (fifthAnswer == "Hydrogen")
                {
                    count += 10;
                }
                TempData["quizResult"] = TempData["name"] + " you haved scored " + count + "/50";
            }
            

            return RedirectToAction("QuizResults");
        }


        public ActionResult QuizResults(string name)
        {
            ViewBag.result = TempData["quizResult"].ToString();
            name = TempData["name"].ToString();
            if(name == null)
            {
                return RedirectToAction("DisplayQuiz", "Quiz");
            }
            else
            {
                return View();
            }
            
        }

        public ActionResult QuizQuesAndAns()
        {
            PeriodicTableQuizEntities db = new PeriodicTableQuizEntities();
            List<AnswerChoice> answers = db.AnswerChoices.ToList();

            return View(answers);
        }

        [HttpPost]
        public ActionResult QuizQuesAndAns(AnswerChoice answer)
        {
            PeriodicTableQuizEntities db = new PeriodicTableQuizEntities();
            

            return RedirectToAction("DisplayQuiz");
        }
    }
}