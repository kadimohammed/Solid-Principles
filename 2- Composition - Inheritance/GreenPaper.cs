using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2__Composition___Inheritance
{
    internal class GreenPaper : ITopping
    {
        public string Title => nameof(GreenPaper);

        public decimal Price => 10.4m;
    }
}
