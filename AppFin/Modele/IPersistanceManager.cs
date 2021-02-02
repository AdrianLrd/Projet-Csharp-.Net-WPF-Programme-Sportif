using System;
using System.Collections.Generic;
using System.Text;

namespace Modele
{
    /// <summary>
    /// Gestionnaire de la Persistance
    /// </summary>
    public interface IPersistanceManager
    {
        (IEnumerable<Programme> tousprogrammes, IEnumerable<Activite> tousactivites, IEnumerable<Utilisateur> tousutilisateurs) ChargeDonnées();

        void SauvegardeDonnées(IEnumerable<Programme> tousprogrammes, IEnumerable<Activite> tousactivites, IEnumerable<Utilisateur> tousutilisateurs);
    }
}
