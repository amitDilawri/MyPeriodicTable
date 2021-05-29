using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyPeriodicTable.Models;

namespace MyPeriodicTable.View_Model
{
    public class QuizProperties
    {
        public Dictionary<int, QuizQuesAndAnswers> questionsDictionary { get; set; }

        public List<QuizQuesAndAnswers> questions { get; set; }
    }
}