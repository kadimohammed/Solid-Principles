using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7__Interface_Segregation.Before
{
    internal class ImprimanteSimple : IMachine
    {
        public void Imprimer()
        {
            Console.WriteLine("Impression en cours...");
        }

        public void Scanner()
        {
            // Pas besoin de scanner, mais il faut quand même implémenter cette méthode
            throw new NotImplementedException();
        }

        public void Faxer()
        {
            // Pas besoin non plus, mais obligé d'implémenter
            throw new NotImplementedException();
        }
    }
}
