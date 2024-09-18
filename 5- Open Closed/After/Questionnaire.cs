using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5__Open_Closed.After
{
    internal class Questionnaire
    {
        public static List<Question> GenererListeDesQuestions()
        {
            List<Question> listeQuestions = new List<Question>();

            // Question de type WH
            WHQuestion q1 = new WHQuestion("Quelle est la capitale de la France ?", 5);
            listeQuestions.Add(q1);

            // Question de type VRAIFALSE
            TrueFalseQuestion q2 = new TrueFalseQuestion("Le soleil tourne autour de la Terre.", 2);
            listeQuestions.Add(q2);

            // Question de type CHOIXMULTIPLE avec des choix
            ChoixMultipleQuestion q3 = new ChoixMultipleQuestion("Quel est le plus grand océan du monde ?", 3);
            q3.Choix.Add("Océan Atlantique");
            q3.Choix.Add("Océan Pacifique");
            q3.Choix.Add("Océan Indien");
            q3.Choix.Add("Océan Arctique");
            listeQuestions.Add(q3);

            return listeQuestions;
        }
    }
}
