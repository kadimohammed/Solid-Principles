using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5__Open_Closed.After
{
    internal abstract class Question
    {
        protected string Titre { get; set; }
        protected int Mark { get; set; }

        protected Question()
        {
            
        }
        protected Question(string titre, int mark)
        {
            Mark = mark;
            Titre = titre;
        }
        public abstract void Print();
    }
}
