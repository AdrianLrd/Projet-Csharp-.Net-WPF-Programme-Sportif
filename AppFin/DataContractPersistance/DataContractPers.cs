using Modele;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml;

namespace DataContractPersistance
{
    public class DataContractPers : IPersistanceManager
    {
        public string FilePath { get; set; } = Path.Combine(Directory.GetCurrentDirectory(), "..//XML");

        public string FileName { get; set; } = "sport.xml";

         string PersFile => Path.Combine(FilePath, FileName);

        internal List<Programme> LesProgrammes { get; set; } = new List<Programme>();
        internal List<Activite> LesActivites { get; set; } = new List<Activite>();
        internal List<Utilisateur> LesUtilisateur { get; set; } = new List<Utilisateur>();
        private DataContractSerializer Serializer { get; set; } = new DataContractSerializer(typeof(DataToPersist),
                                                                    new DataContractSerializerSettings()
                                                                    {
                                                                        PreserveObjectReferences = true
                                                                    });

        public (IEnumerable<Programme> tousprogrammes, IEnumerable<Activite> tousactivites, IEnumerable<Utilisateur> tousutilisateurs) ChargeDonnées()
        {
            if (!File.Exists(PersFile))
            {
                throw new FileNotFoundException("Le fichier de persistance est manquant !");
            }
           

            DataToPersist data;

            using (Stream s = File.OpenRead(PersFile))
            {
                data = Serializer.ReadObject(s) as DataToPersist;
            }

            LesProgrammes = data.Programmes.ToPOCOs().ToList();

            LesActivites = data.Activites.ToPOCOs().ToList();

            LesUtilisateur = data.Utilisateurs.ToPOCOs().ToList();

            return (LesProgrammes, LesActivites, LesUtilisateur);
        }

        public void SauvegardeDonnées(IEnumerable<Programme> tousprogrammes, IEnumerable<Activite> tousactivites, IEnumerable<Utilisateur> tousutilisateurs)
        {

            if (!Directory.Exists(FilePath))
            {
                Directory.CreateDirectory(FilePath);
            }

            DataToPersist data = new DataToPersist();
            data.Programmes.AddRange(tousprogrammes.ToDTOs());
            data.Activites.AddRange(tousactivites.ToDTOs());
            data.Utilisateurs.AddRange(tousutilisateurs.ToDTOs());

            var settings = new XmlWriterSettings() {Indent = true };
            using (TextWriter tw = File.CreateText(PersFile))
            {
                using (XmlWriter writer = XmlWriter.Create(tw, settings))
                {
                    Serializer.WriteObject(writer, data);
                }
            }
        }
    }
}
