using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1__Encapsulate_What_Varies
{
    internal class Pizza
    {
        public virtual string Title { get => nameof(Pizza); }
        public virtual decimal Price { get => 10; }


        public override string ToString()
        {
            return $"Title : {Title}  Price : {Price}";
        }

        // la partie li katbaddel kan3ezloha f method ba7edha
        private static Pizza Create(string type)
        {
            Pizza pizza;
            if (type == PizzaTypes.ChickenPizza)
            {
                pizza = new Chicken();
            }
            else
            {
                pizza = new Cheese();
            }
            return pizza;
        } 

        public static Pizza Order(string type)
        {
            Pizza pizza = Create(type);
            Prepare();
            Cooking();
            Cut();
            return pizza;
        }


        private static void Prepare()
        {
            Console.WriteLine("Prepare...");
            Thread.Sleep(1000);
        }

        private static void Cooking()
        {
            Console.WriteLine("Cooking...");
            Thread.Sleep(1000);
        }

        private static void Cut()
        {
            Console.WriteLine("Cut....");
            Thread.Sleep(1000);
            Console.WriteLine("completed.");
        }




    }
}
