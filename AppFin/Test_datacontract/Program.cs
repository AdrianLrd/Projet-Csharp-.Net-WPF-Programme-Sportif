using Modele;
using System;

namespace Test_datacontract
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("--------------------------Chargement des données avec le Stub-----------------------");
            Gestionnaire gestionnaire = new Gestionnaire(new Stub.Stub());
            gestionnaire.ChargeDonnées();
            gestionnaire.Persistance = new DataContractPersistance.DataContractPers();
            gestionnaire.SauvegardeDonnées();


            Console.WriteLine("--------------------------Chargement des données avec DataContract-----------------------");

            Gestionnaire gestionnaire1 = new Gestionnaire(new DataContractPersistance.DataContractPers());
            gestionnaire1.ChargeDonnées();

        }
    }
}
