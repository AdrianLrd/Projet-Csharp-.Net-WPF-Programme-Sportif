using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Modele
{
	public class Utilisateur
    {

		/// <summary>
		/// Mot de passe de l'utilisateur.
		/// </summary>
		public string Mdp { get; set; }
		/// <summary>
		/// Pseudo de l'utilisateur de maniere a ne pas afficher le mail de l'utilisateur sur l'application.
		/// </summary>
		public string Pseudo { get; set; }

		/// <summary>
		/// Mail unique de l'utilisateur.
		/// </summary>
		public string Mail
		{
			get => mail;
		}

		private readonly string mail = "rien";


		public Utilisateur(string pseudo, string mdp, string mail)
		{
			Pseudo = pseudo;
			Mdp = mdp;
			this.mail = mail;
		}



		public Utilisateur(string mail)
		{
			this.mail = mail;
		}


        public bool Equals(Utilisateur other)
        {
            return Mail == other.Mail;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (obj == this) return true;
            if (obj.GetType() != GetType()) return false;
            return base.Equals(obj as Utilisateur);
        }

        public Utilisateur SingleOrDefault(Func<object, object> p)
		{
			throw new NotImplementedException();
		}

        //public override int GetHashCode()
        //{
        //    return Mail.GetHashCode();
        //}

        public override string ToString()
		{
			return $"{Pseudo} {Mail} ";
		}

	}

}
