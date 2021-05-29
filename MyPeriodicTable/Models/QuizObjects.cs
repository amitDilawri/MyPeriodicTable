using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyPeriodicTable.Models
{
    public static class QuizObjects
    {
 
        public static Dictionary<int, QuizQuesAndAnswers> dictionaryOfQuestions = new Dictionary<int, QuizQuesAndAnswers>()
        {
            { 1, new QuizQuesAndAnswers{ Question = "What is the symbol for Iron?", Option_1 = "Ir", Option_2 = "I", Option_3 = "Fe", Option_4 = "Fm", InputAnswer = null, CorrectAnswer = "Fe"} },
            { 2, new QuizQuesAndAnswers{ Question = "Which one of the following is not a noble gas?", Option_1 = "Helium", Option_2 = "Nitrogen", Option_3 = "Neon", Option_4 = "Argon", InputAnswer = null} },
            { 3, new QuizQuesAndAnswers{ Question = "Cu is the symbol of which element?", Option_1 = "Copper", Option_2 = "Carbon", Option_3 = "Calcium", Option_4 = "Chlorine", InputAnswer = null} },
            { 4, new QuizQuesAndAnswers{ Question = "How many total elements are in the periodic table?", Option_1 = "119", Option_2 = "100", Option_3 = "150", Option_4 = "118", InputAnswer = null} },
            { 5, new QuizQuesAndAnswers{ Question = "Which element has an atomic number 1?", Option_1 = "Lithium", Option_2 = "Hydrogen", Option_3 = "Helium", Option_4 = "Boron", InputAnswer = null } }
        };

        
    }
}

//dictionaryOfQuestions.Values.Select(x => x.Option_3).ToString()