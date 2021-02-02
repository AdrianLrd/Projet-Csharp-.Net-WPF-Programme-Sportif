using Modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace DataContractPersistance
{
    [DataContract]
    class ActivitéDTO
    {

        /// <summary>
        /// Nom de l'activité.
        /// </summary>
        [DataMember(EmitDefaultValue = false, Order = 1)]
        public string NomAct { get; set; }

        /// <summary>
        /// Durée de l'activité.
        /// </summary>
        [DataMember(EmitDefaultValue = false, Order = 2)]
        public int Duree { get; set; }

        /// <summary>
        /// Nombre de série.
        /// </summary>
        [DataMember(EmitDefaultValue = false, Order = 3)]
        public int NbSerie { get; set; }

        /// <summary>
        /// Nombre de répétition.
        /// </summary>
        [DataMember(EmitDefaultValue = false, Order = 4)]
        public int NbRep { get; set; }

        /// <summary>
        /// Description de l'activité.
        /// </summary>
        [DataMember(EmitDefaultValue = false, Order = 5)]
        public string Desc { get; set; }

        /// <summary>
        /// Id unique de l'activité.
        /// </summary>
        
        [DataMember(Order = 0)]
        public string UniqueId { get; set; }

    }

    static class ActiviteExtensions
    {
        public static Activite ToPOCO(this ActivitéDTO dto)
            => new Activite(dto.UniqueId, dto.NomAct, dto.Duree, dto.NbSerie, dto.NbRep, dto.Desc);


        public static IEnumerable<Activite> ToPOCOs(this IEnumerable<ActivitéDTO> dtos)
            => dtos.Select(dto => dto.ToPOCO());

        public static ActivitéDTO ToDTO(this Activite poco)
            => new ActivitéDTO
            {
                UniqueId = poco.UniqueId,
                NomAct = poco.NomAct,
                Duree = poco.Duree,
                NbSerie = poco.NbSerie,
                NbRep = poco.NbRep,
                Desc = poco.Desc
            };
        public static IEnumerable<ActivitéDTO> ToDTOs(this IEnumerable<Activite> pocos)
            => pocos.Select(a => a.ToDTO());
    }
}
