using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyPeriodicTable.Models;

namespace MyPeriodicTable.Models
{
    public class QuizAnswer
    {
        public List<QuizQuesAndAnswers> QandAList { get; set; }

        public string CorrectAnswer { get; set; }
    }
}