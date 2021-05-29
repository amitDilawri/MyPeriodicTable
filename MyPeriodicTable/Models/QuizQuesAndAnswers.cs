using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyPeriodicTable.Models
{
    public class QuizQuesAndAnswers
    {
        public string Question { get; set; }
        public string Option_1 { get; set; }
        public string Option_2 { get; set; }
        public string Option_3 { get; set; }
        public string Option_4 { get; set; }
        public string InputAnswer { get; set; }
        public string CorrectAnswer { get; set; }
    }
}