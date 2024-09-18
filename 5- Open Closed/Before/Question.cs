using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5__Open_Closed.Before
{
    internal class Question
    {
        public string Titre { get; set; }
        public int Mark { get; set; }
        public QuestionType questionType { get; set; }
        public List<string> Choix { get; set; }


        public Question()
        {
            Choix = new List<string>();
        }

        public Question(string titre, int mark, QuestionType questionType)
        {
            Choix = new List<string>();
            Titre = titre;
            Mark = mark;
            this.questionType = questionType;
        }
    }
}
