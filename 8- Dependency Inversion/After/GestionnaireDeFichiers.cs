using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8__Dependency_Inversion.After
{
    internal class GestionnaireDeFichiers
    {
        private ISauvegarde sauvegarde;

        // Injection de dépendance via le constructeur
        public GestionnaireDeFichiers(ISauvegarde sauvegarde)
        {
            this.sauvegarde = sauvegarde;
        }

        public void SauvegarderFichier(string contenu)
        {
            sauvegarde.Sauvegarder(contenu);
        }
    }
}
