using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7__Interface_Segregation.After
{
    internal class MachineMultifonction : IImprimante,IScanner,IFax
    {
        public void Imprimer()
        {
            Console.WriteLine("Impression en cours...");
        }

        public void Scanner()
        {
            Console.WriteLine("Scan en cours...");
        }

        public void Faxer()
        {
            Console.WriteLine("Envoi du fax...");
        }
    }
}
