


using _8__Dependency_Inversion.After;

ISauvegarde fichierTexte = new FichierTexte();
GestionnaireDeFichiers gestionnaire1 = new GestionnaireDeFichiers(fichierTexte);
gestionnaire1.SauvegarderFichier("Contenu pour fichier texte");

ISauvegarde baseDeDonnees = new BaseDeDonnees();
GestionnaireDeFichiers gestionnaire2 = new GestionnaireDeFichiers(baseDeDonnees);
gestionnaire2.SauvegarderFichier("Contenu pour base de données");