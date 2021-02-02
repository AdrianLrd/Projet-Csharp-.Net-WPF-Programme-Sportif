using Modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace DataContractPersistance
{

	[DataContract]
	class UtilisateurDTO
    {
		/// <summary>
		/// Mot de passe de l'utilisateur.
		/// </summary>
		[DataMember(EmitDefaultValue = false, Order = 2)]
		public string Mdp { get; set; }
		/// <summary>
		/// Pseudo de l'utilisateur de maniere a ne pas afficher le mail de l'utilisateur sur l'application.
		/// </summary>
		[DataMember(EmitDefaultValue = false, Order = 1)]
		public string Pseudo { get; set; }

		/// <summary>
		/// Mail unique de l'utilisateur.
		/// </summary>
		[DataMember(Order = 0)]
		public string Mail { get; set; }
	}

	static class UtilisateurExtensions
	{
		public static Utilisateur ToPOCO(this UtilisateurDTO dto)
			=> new Utilisateur(dto.Pseudo, dto.Mdp, dto.Mail);


		public static IEnumerable<Utilisateur> ToPOCOs(this IEnumerable<UtilisateurDTO> dtos)
			=> dtos.Select(dto => dto.ToPOCO());

		public static UtilisateurDTO ToDTO(this Utilisateur poco)
			=> new UtilisateurDTO
			{
				Pseudo = poco.Pseudo,
				Mdp = poco.Mdp,
				Mail = poco.Mail
			};
		public static IEnumerable<UtilisateurDTO> ToDTOs(this IEnumerable<Utilisateur> pocos)
			=> pocos.Select(u => u.ToDTO());
	}
}
