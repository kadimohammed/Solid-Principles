using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2__Composition___Inheritance
{
    internal class Pizza
    {
        public string Title =>  nameof(Pizza);
        public decimal Price =>  10.5m;
        public IList<ITopping> topping { get; set; }

        public Pizza()
        {
            topping = new List<ITopping>();
        }

        public void AddTopping(ITopping t)
        {
            topping.Add(t);
        }

        public decimal CalculeToppingPrice()
        {
            decimal totale = Price;
            foreach (var tp in topping)
            {
                totale+= tp.Price;
                Console.WriteLine($"{tp.Title} => price :{tp.Price}");
            }
            return totale;
        }

        public override string ToString()
        {
            return $"{Title} => Base Price: {Price}\nTotale : {CalculeToppingPrice()}";
        }
    }
}
