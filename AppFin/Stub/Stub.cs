using Modele;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Stub
{
    public class Stub : IPersistanceManager
    {

        /// <summary>
        /// Chargement des données 
        /// </summary>
        /// <returns></returns>
        public (IEnumerable<Programme> tousprogrammes, IEnumerable<Activite> tousactivites, IEnumerable<Utilisateur> tousutilisateurs) ChargeDonnées()
        {
            List<Programme> lesProgrammes = ChargeProgramme();
            List<Activite> lesActivictés = ChargeActivite();
            List<Utilisateur> lesUtilisateurs = ChargeUtilisateur();
            return (lesProgrammes, lesActivictés, lesUtilisateurs);
        }

        /// <summary>
        /// Sauvegarde des données
        /// </summary>
        /// <param name="tousprogrammes"></param>
        /// <param name="tousactivites"></param>
        /// <param name="tousutilisateurs"></param>
        public void SauvegardeDonnées(IEnumerable<Programme> tousprogrammes, IEnumerable<Activite> tousactivites, IEnumerable<Utilisateur> tousutilisateurs)
        {
            Debug.WriteLine("Sauvegarde demandée");
        }


        /// <summary>
        /// Rend 3 programmes quelconque
        /// </summary>
        /// <returns></returns>
        private List<Programme> ChargeProgramme()
        {
            List<Programme> tousprogrammes = new List<Programme>();
            tousprogrammes.Add(new Programme("prog1", "MaisonSport", 4, "Lundi, Mardi", Intensite.Intermediaire, Objectif.Perte));
            tousprogrammes.Add(new Programme("prog2", "Maison", 3, "Jeudi, Dimanche", Intensite.Expert, Objectif.Prise));
            tousprogrammes.Add(new Programme("prog3", "SalleSport", 5, "Lundi", Intensite.Debutant, Objectif.Tonifier));
            return tousprogrammes;
        }

        /// <summary>
        /// Rend 3 Activités quelconque
        /// </summary>
        /// <returns></returns>
        private List<Activite> ChargeActivite()
        {
            List<Activite> tousactivites = new List<Activite>();
            tousactivites.Add(new Activite("activité1", "balançoire", 45, 15, 3, "lalalala une description"));
            tousactivites.Add(new Activite("activité2", "vélo", 30, 10, 3, "Une autre description"));
            tousactivites.Add(new Activite("activité3", "course", 60, 5, 5, "Encore une autre"));
            return tousactivites;
        }

        /// <summary>
        /// Rend 3 Utilisateurs quelconque
        /// </summary>
        /// <returns></returns>
        private List<Utilisateur> ChargeUtilisateur()
        {
            List<Utilisateur> tousutilisateurs = new List<Utilisateur>();
            tousutilisateurs.Add(new Utilisateur("Paolo", "jetest", "adrian.lardon"));
            tousutilisateurs.Add(new Utilisateur("Mathieu", "jetest", "mathieu.albiero"));
            return tousutilisateurs;
        }


    }
}
