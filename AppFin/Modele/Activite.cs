using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Modele
{
    public class Activite
    {
        /// <summary>
        /// Nom de l'activité.
        /// </summary>
        public string NomAct { get; set; }

        /// <summary>
        /// Durée de l'activité.
        /// </summary>
        public int Duree { get; set; }

        /// <summary>
        /// Nombre de série.
        /// </summary>
        public int NbSerie { get; set; }

        /// <summary>
        /// Nombre de répétition.
        /// </summary>
        public int NbRep { get; set; }

        /// <summary>
        /// Description de l'activité.
        /// </summary>
        public string Desc { get; set; }

        /// <summary>
        /// Id unique de l'activité.
        /// </summary>
        public string UniqueId
        {
            get => uniqueId;
        }
        private readonly string uniqueId;

        /// <summary>
        /// Constructeur d'Activité
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nomAct"></param>
        /// <param name="duree"></param>
        /// <param name="nbSerie"></param>
        /// <param name="nbRep"></param>
        /// <param name="desc"></param>
        public Activite (string id, string nomAct, int duree, int nbSerie, int nbRep, string desc)
        {

            uniqueId = id;
            NomAct = nomAct;
            Duree = duree;
            NbSerie = nbSerie;
            NbRep = nbRep;
            Desc = desc;
        }

        /// <summary>
        /// Constructeur d'Avtivité avec 1 seul paramètre
        /// </summary>
        /// <param name="id"></param>
        public Activite(string id)
        {
            uniqueId = id;
        }


        public bool Equals(Activite other)
        {
            return UniqueId == other.UniqueId;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (obj == this) return true;
            if (obj.GetType() != GetType()) return false;
            return base.Equals(obj as Activite);
        }

        public Activite SingleOrDefault(Func<object, object> p)
        {
            throw new NotImplementedException();
        }

        //public override int GetHashCode()
        //{
        //    return UniqueId.GetHashCode();
        //}

        public override string ToString()
        {
            return $"{NomAct} {uniqueId} ";
        }
    }
}
