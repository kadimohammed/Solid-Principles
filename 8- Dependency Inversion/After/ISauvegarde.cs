using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8__Dependency_Inversion.After
{
    internal interface ISauvegarde
    {
        void Sauvegarder(string contenu);
    }
}
