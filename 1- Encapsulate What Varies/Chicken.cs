using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1__Encapsulate_What_Varies
{
    internal class Chicken : Pizza
    {
        public override string Title { get => base.Title + nameof(Chicken); }
        public override decimal Price { get => base.Price + 10; }
    }
}
