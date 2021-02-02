using Modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;

namespace DataContractPersistance
{
	[DataContract]
	class ProgrammeDTO
	{
		/// <summary>
		/// Nom du programme.
		/// </summary>
		[DataMember(EmitDefaultValue = false, Order = 1)]
		public string NomProg { get; set; }
		/// <summary>
		/// Note du programme.
		/// </summary>
		[DataMember(EmitDefaultValue = false, Order = 2)]
		public float Note { get; set; }
		/// <summary>
		/// La periodicité corespond au nombre de fois que sera réaliser le programme.
		/// </summary>
		[DataMember(EmitDefaultValue = false, Order = 3)]
		public string Periodicite { get; set; }
		/// <summary>
		/// L'intensité corespond à la difficulté du programme.
		/// </summary>
		[DataMember(EmitDefaultValue = false, Order = 4)]
		public Intensite _intensite { get; set; }
		/// <summary>
		/// L'objectif du programme
		/// </summary>
		[DataMember(EmitDefaultValue = false, Order = 5)]
		public Objectif _objectif { get; set; }

		/// <summary>
		/// Liste des activités dans le programme
		/// </summary>
		public List<Activite> Activites;

		/// <summary>
		/// ID unique du programme.
		/// </summary>
		public string UniqueId { get; set; }
	}

	static class ProgrammeExtensions
    {
        public static Programme ToPOCO(this ProgrammeDTO dto)
			=> new Programme(dto.UniqueId, dto.NomProg, dto.Periodicite, dto._intensite, dto._objectif);
        

        public static IEnumerable<Programme> ToPOCOs(this IEnumerable<ProgrammeDTO> dtos)
			=> dtos.Select(dto => dto.ToPOCO());

		public static ProgrammeDTO ToDTO(this Programme poco)
			=> new ProgrammeDTO
			{
				UniqueId = poco.UniqueId,
				NomProg = poco.NomProg,
				Periodicite = poco.Periodicite,
				_intensite = poco._intensite,
				_objectif = poco._objectif
			};
		public static IEnumerable<ProgrammeDTO> ToDTOs(this IEnumerable<Programme> pocos)
			=> pocos.Select(p => p.ToDTO());
    }
}
