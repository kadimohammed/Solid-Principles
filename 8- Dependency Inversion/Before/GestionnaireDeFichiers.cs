using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8__Dependency_Inversion.Before
{
    internal class GestionnaireDeFichiers
    {
        private FichierTexte fichierTexte = new FichierTexte();

        public void SauvegarderFichier(string contenu)
        {
            fichierTexte.Sauvegarder(contenu);
        }
    }
}
