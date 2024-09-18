using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5__Open_Closed.After
{
    internal class TrueFalseQuestion : Question
    {
        public TrueFalseQuestion(string titre, int mark) : base(titre, mark)
        {
            Titre = titre;
            Mark = mark;
        }

        public override void Print()
        {
            Console.WriteLine(Titre);
            Console.WriteLine("1- TRUE");
            Console.WriteLine("2- FALSE");
            Console.WriteLine("");
        }
    }
}
