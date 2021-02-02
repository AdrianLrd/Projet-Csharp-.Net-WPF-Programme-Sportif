using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;

namespace Modele
{
    public class Gestionnaire : INotifyPropertyChanged
    {
        /// <summary>
        /// Dépendance vers le gestionnaire de la persistance
        /// </summary>
        public IPersistanceManager Persistance { get;  set; }

        /// <summary>
        /// Charge les données contenu dans la persistance
        /// </summary>
        public void ChargeDonnées()
        {
            var données = Persistance.ChargeDonnées();
            foreach(var j in données.tousprogrammes)
            {
                tousprogrammes.Add(j);
            }
            foreach (var j in données.tousactivites)
            {
                tousactivites.Add(j);
            }
            foreach (var j in données.tousutilisateurs)
            {
                tousutilisateurs.Add(j);
            }

        }

        /// <summary>
        /// Sauvegarde des données via la Persistance.
        /// </summary>
        public void SauvegardeDonnées()
        {
            Persistance.SauvegardeDonnées(tousprogrammes, tousactivites, tousutilisateurs);
        }

        /// <summary>
        /// Liste de tous les programmes de l'application.
        /// </summary>
        public ReadOnlyObservableCollection<Programme> Tousprogrammes { get; private set; }
        ObservableCollection<Programme> tousprogrammes = new ObservableCollection<Programme>();
        
        /// <summary>
        /// Liste de tous les programmes de l'application.
        /// </summary>
        public ReadOnlyObservableCollection<Activite> Tousactivites { get; private set; }
        ObservableCollection<Activite> tousactivites = new ObservableCollection<Activite>();

        /// <summary>
        /// Liste de tous les utlisateur de l'application.
        /// </summary>
        public ReadOnlyObservableCollection<Utilisateur> Tousutilisateur { get; private set; }
        ObservableCollection<Utilisateur> tousutilisateurs = new ObservableCollection<Utilisateur>();

        /// <summary>
        /// Ajoute un programme à la liste de programme.
        /// </summary>
        public bool AjouteProg(Programme prog)
        {
            if (tousprogrammes.Contains(prog))
            {
                return false;
            }
            tousprogrammes.Add(prog);
            return true;
        }

        /// <summary>
        /// Supprime un programme à la liste de programmes.
        /// </summary>
        public bool SupprProgramme(Programme prog)
        {

            if (!tousprogrammes.Contains(prog))
            {
                return false;
            }
            tousprogrammes.Remove(prog);
            return true;

        }


        
        /// <summary>
        /// Rend le programme égale a ce uniqID.
        /// </summary>
        ///
        public Programme GetProg(string uniqueId)
        {
            return tousprogrammes.SingleOrDefault(p => p.UniqueId == uniqueId);
        }


        /// <summary>
        /// Chargement du gestionnaire avec les différentes listes
        /// </summary>
        /// <param name="persistance"></param>
        public Gestionnaire(IPersistanceManager persistance)
        {
            Persistance = persistance;
            Tousprogrammes = new ReadOnlyObservableCollection<Programme>(tousprogrammes);
            Tousactivites = new ReadOnlyObservableCollection<Activite>(tousactivites);
            Tousutilisateur = new ReadOnlyObservableCollection<Utilisateur>(tousutilisateurs);
        }



        public event PropertyChangedEventHandler PropertyChanged;


        void OnPropertyChanged(string propertyName)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        /// <summary>
        /// Ajoute une Activite à la liste d'Activite.
        /// </summary>
        public bool AjouterActivite(Activite a)
        {
            if (tousactivites.Contains(a))
            {
                return false;
            }
            tousactivites.Add(a);
            return true;
        }


        /// <summary>
        /// Rend l'Activite égale a l'uniqID.
        /// </summary>
        public Activite GetActivite(string uniqueId)
        {
            return tousactivites.SingleOrDefault(a => a.UniqueId == uniqueId);
        }



        /// <summary>
        /// Utilisateur courant de l'appli.
        /// </summary>
        private Utilisateur utilisateurConnecte = new Utilisateur("rien","rien","rien");
        public Utilisateur UtilisateurConnecte
        {
            get
            {
                return utilisateurConnecte;
            }
            set
            {
                utilisateurConnecte = value;
            }
        }
        /// <summary>
        /// Supprime une activité à la liste d'activité.
        /// </summary>
        public bool SupprActivite(Activite a)
        {

            if (!tousactivites.Contains(a))
            {
                return false;
            }
            tousactivites.Remove(a);
            return true;

        }

        /// <summary>
        /// Ajoute un Utilisateur à la liste d'Utilisateur.
        /// </summary>
        public bool AjouteUtilisateur(Utilisateur u)
        {
            if (tousutilisateurs.Contains(u))
            {
                return false;
            }
            tousutilisateurs.Add(u);
            return true;
        }

        /// <summary>
        /// Supprime un utilisateur à la liste des utilisateur.
        /// </summary>
        public bool SupprUtilisateur(Utilisateur u)
        {

            if (!tousutilisateurs.Contains(u))
            {
                return false;
            }
            tousutilisateurs.Remove(u);
            return true;
        }

        /// <summary>
        /// Rend l'utlisateur égale a ce mail.
        /// </summary>
        public Utilisateur GetUtilisateur(string mail)
        {
            return tousutilisateurs.SingleOrDefault(u => u.Mail == mail);
        }

        /// <summary>
        /// Rend true si l'utilisateur existe sinon il n'existe pas.
        /// </summary>
        public bool Login(string Mail, string MDP)
        {
            Utilisateur u = GetUtilisateur(Mail);
            if(u!= null)
            {
                if(u.Mdp == MDP)
                {
                    return true;
                }
                return false;
            }
            return false;
        }
    }
}