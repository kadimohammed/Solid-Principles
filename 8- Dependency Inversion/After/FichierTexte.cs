using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8__Dependency_Inversion.After
{
    internal class FichierTexte : ISauvegarde
    {
        public void Sauvegarder(string contenu)
        {
            Console.WriteLine("Sauvegarde dans un fichier texte : " + contenu);
        }
    }
}
