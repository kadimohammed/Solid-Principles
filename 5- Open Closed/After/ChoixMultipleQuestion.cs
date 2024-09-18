using _5__Open_Closed.Before;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5__Open_Closed.After
{
    internal class ChoixMultipleQuestion : Question
    {
        public List<string> Choix { get; set; }

        public ChoixMultipleQuestion() : base()
        {
            Choix = new List<string>();
        }

        public ChoixMultipleQuestion(string titre, int mark) : base(titre, mark)
        {
            Choix = new List<string>();
            Titre = titre;
            Mark = mark;
        }

        public override void Print()
        {
            Console.WriteLine(Titre);
            int cmp = 1;
            foreach (var ch in Choix)
            {
                Console.WriteLine(cmp+"-"+ch);
                cmp++;
            }
            Console.WriteLine("");
        }
    }
}
