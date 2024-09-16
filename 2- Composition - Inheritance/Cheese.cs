using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2__Composition___Inheritance
{
    internal class Cheese : ITopping
    {
        public string Title => nameof(Cheese);

        public decimal Price => 20;
    }
}
