using DataContractPersistance;
using Modele;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace AppFin
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public Gestionnaire gestionnaire { get; private set; } = new Gestionnaire(new DataContractPers());

        public App() : base()
        {
            gestionnaire.ChargeDonnées();
        }
    }
}
