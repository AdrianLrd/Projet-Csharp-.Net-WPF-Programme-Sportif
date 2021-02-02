using Modele;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace DataContractPersistance
{
    [DataContract]
    class DataToPersist
    {
        [DataMember]
        public List<ProgrammeDTO> Programmes { get; set; } = new List<ProgrammeDTO>();

        [DataMember]
        public List<ActivitéDTO> Activites { get; set; } = new List<ActivitéDTO>();

        [DataMember]
        public List<UtilisateurDTO> Utilisateurs { get; set; } = new List<UtilisateurDTO>();
    }
}
