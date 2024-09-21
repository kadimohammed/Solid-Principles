using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7__Interface_Segregation.After
{
    internal class ImprimanteSimple : IImprimante
    {
        public void Imprimer()
        {
            Console.WriteLine("Impression en cours...");
        }
    }
}
