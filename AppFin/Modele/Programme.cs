using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Modele
{
	public class Programme 
    {
		/// <summary>
		/// Nom du programme.
		/// </summary>
		public string NomProg { get; set; }
		/// <summary>
		/// Note du programme.
		/// </summary>
		public float Note { get; set; }
		/// <summary>
		/// La periodicité corespond au nombre de fois que sera réaliser le programme.
		/// </summary>
		public string Periodicite { get; set; }
		/// <summary>
		/// L'intensité corespond à la difficulté du programme.
		/// </summary>
		public Intensite _intensite { get; set; }
		/// <summary>
		/// L'objectif du programme
		/// </summary>
		public Objectif _objectif { get; set; }
		
		/// <summary>
		/// Liste des activités dans le programme
		/// </summary>
		public List<Activite> Activites;


		/// <summary>
		/// ID unique du programme.
		/// </summary>
		public string UniqueId
        {
            get => uniqueId;
        }

		private readonly string uniqueId;

		public Programme(string id, string nomProg, float note, string periodicites, Intensite intensite, Objectif objectif)
		{
			uniqueId = id;
			NomProg = nomProg;
			Note = note;
			Periodicite = periodicites;
			_intensite = intensite;
			_objectif = objectif;
		}

		public Programme(string id, string nomProg, string periodicites, Intensite intensite, Objectif objectif)
		{
			uniqueId = id;
			NomProg = nomProg;
			Periodicite = periodicites;
			_intensite = intensite;
			_objectif = objectif;
		}

		public Programme(string id)
		{
			uniqueId = id;
		}


		public override string ToString()
		{
			return $"{NomProg} {uniqueId} ";
		}

		public bool Equals(Programme other)
		{
			return UniqueId == other.UniqueId;
		}

		public override bool Equals(object obj)
		{
			if (obj == null) return false;
			if (obj == this) return true;
			if (obj.GetType() != GetType()) return false;
			return base.Equals(obj as Programme);
		}

		public Programme SingleOrDefault(Func<object, object> p)
		{
			throw new NotImplementedException();
		}

        //public override int GetHashCode()
        //{
        //    return UniqueId.GetHashCode();
        //}

    }

}
