using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5__Open_Closed.Before
{
    internal class Examen
    {
        public List<Question> questions { get; }


        public Examen(List<Question> questions)
        {
            this.questions = questions;
        }


        public void Print()
        {
            foreach (var q in questions)
            {
                Console.WriteLine(q.Titre);
                if (q.questionType == QuestionType.WH)
                {
                    Console.WriteLine("................................");
                    Console.WriteLine("................................");
                    Console.WriteLine("................................");
                }
                else if (q.questionType == QuestionType.TRUEFALSE)
                {
                    Console.WriteLine("1- TRUE");
                    Console.WriteLine("2- FALSE");
                }
                else if (q.questionType == QuestionType.CHOIXMULTIPLE)
                {
                    foreach (var ch in q.Choix)
                    {
                        Console.WriteLine(ch);
                    }
                }
                Console.WriteLine("");
            }
        }
    }
}
