using Modele;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Gestionnaire gestionnaire = new Gestionnaire(new Stub.Stub());

            ReadOnlyObservableCollection<Programme> programmes = gestionnaire.Tousprogrammes;
            Programme prog= new Programme("progtest", "Test", "Lundi, Mardi", Intensite.Debutant, Objectif.Tonifier);

            Programme prog1 = new Programme("dd", "Test", "Mardi", Intensite.Debutant, Objectif.Forme);


            Console.WriteLine("--------------------------AJOUT-----------------------");
            gestionnaire.AjouteProg(prog);
            gestionnaire.AjouteProg(prog1);
            foreach (Programme p in programmes)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine("--------------------------SUPPRESSION-----------------------");
            gestionnaire.SupprProgramme(prog1);


            foreach (Programme p in programmes)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine("--------------------------GetProg-------------------");

            Console.WriteLine(gestionnaire.GetProg(prog.UniqueId));

            Console.WriteLine("--------------------------ACTIVITE---------------------");

            ReadOnlyObservableCollection<Activite> activites = gestionnaire.Tousactivites;
            Activite activ = new Activite("testactiv", "activitetest", 5, 10, 5, "pour la maison");

            Activite activ1 = new Activite("testact", "activitetest1", 10, 15, 10, "pour la salle de sport");



            Console.WriteLine("--------------------------AJOUT-----------------------");
            gestionnaire.AjouterActivite(activ);
            gestionnaire.AjouterActivite(activ1);
            foreach (Activite a in activites)
            {
                Console.WriteLine(a);
            }

            Console.WriteLine("--------------------------SUPPRESSION-----------------------");
            gestionnaire.SupprActivite(activ1);


            foreach (Activite a in activites)
            {
                Console.WriteLine(a);
            }

            Console.WriteLine("--------------------------GetActiviter-------------------");

            Console.WriteLine(gestionnaire.GetActivite(activ1.UniqueId));


            Console.WriteLine("--------------------------UTILISATEUR---------------------");

            ReadOnlyObservableCollection<Utilisateur> utilisateurs = gestionnaire.Tousutilisateur;
            Utilisateur utilisa = new Utilisateur("Pablito", "salut", "clermont.fr");

            Utilisateur utilisa1 = new Utilisateur("Couscous", "hola", "tajine.fr");



            Console.WriteLine("--------------------------AJOUT-----------------------");
            gestionnaire.AjouteUtilisateur(utilisa);
            gestionnaire.AjouteUtilisateur(utilisa1);
            foreach (Utilisateur u in utilisateurs)
            {
                Console.WriteLine(u);
            }

            Console.WriteLine("--------------------------SUPPRESSION-----------------------");
            gestionnaire.SupprUtilisateur(utilisa1);


            foreach (Utilisateur u in utilisateurs)
            {
                Console.WriteLine(u);
            }

            Console.WriteLine("--------------------------GetUtilisateur-------------------");

            Console.WriteLine(gestionnaire.GetUtilisateur(utilisa.Mail));

            Console.WriteLine("--------------------------Login-------------------");

            bool l = gestionnaire.Login("clermont.fr", "salut");

            if(l)
            {
                Console.WriteLine("Login effectué");

            }
            else
            {
                Console.WriteLine("Mauvais login");
            }

        }
    }
}
