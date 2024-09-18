using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5__Open_Closed.After
{
    internal class WHQuestion : Question
    {
        public WHQuestion(string titre, int mark) : base(titre, mark)
        {
        }

        public override void Print()
        {
            Console.WriteLine(Titre);
            Console.WriteLine("................................");
            Console.WriteLine("................................");
            Console.WriteLine("................................");
            Console.WriteLine("");
        }
    }
}
