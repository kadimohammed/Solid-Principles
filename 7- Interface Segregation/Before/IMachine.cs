using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7__Interface_Segregation.Before
{
    internal interface IMachine
    {
        void Imprimer();
        void Scanner();
        void Faxer();
    }
}
