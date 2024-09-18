using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5__Open_Closed.Before
{
    internal class Questionnaire
    {
        public static List<Question> GenererListeDesQuestions()
        {
            List<Question> listeQuestions = new List<Question>();

            // Question de type WH
            Question q1 = new Question("Quelle est la capitale de la France ?", 5, QuestionType.WH);
            listeQuestions.Add(q1);

            // Question de type VRAIFALSE
            Question q2 = new Question("Le soleil tourne autour de la Terre.", 2, QuestionType.TRUEFALSE);
            listeQuestions.Add(q2);

            // Question de type CHOIXMULTIPLE avec des choix
            Question q3 = new Question("Quel est le plus grand océan du monde ?", 3, QuestionType.CHOIXMULTIPLE);
            q3.Choix.Add("Océan Atlantique");
            q3.Choix.Add("Océan Pacifique");
            q3.Choix.Add("Océan Indien");
            q3.Choix.Add("Océan Arctique");
            listeQuestions.Add(q3);

            return listeQuestions;
        }
    }
}
