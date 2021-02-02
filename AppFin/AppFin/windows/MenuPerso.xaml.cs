using Modele;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace AppFin
{
    /// <summary>
    /// Logique d'interaction pour MenuPerso.xaml
    /// </summary>
    public partial class MenuPerso : Window
    {

        public Gestionnaire Manager => (System.Windows.Application.Current as App).gestionnaire;


        public Programme LeProgramme { get; set; }

        public string UniqueId { get; set; }

        public string Jour { get; set; }

        public MenuPerso()
        {
            InitializeComponent();
            LeProgramme = new Programme(UniqueId);
            DataContext = this;

            List<Intensite> intensites = new List<Intensite>();

            intensites.Add(Intensite.Debutant);
            intensites.Add(Intensite.Intermediaire);
            intensites.Add(Intensite.Expert);

            MaComboxBox.ItemsSource = intensites;

            List<Objectif> objectif = new List<Objectif>();

            objectif.Add(Objectif.Forme);
            objectif.Add(Objectif.Perte);
            objectif.Add(Objectif.Prise);
            objectif.Add(Objectif.Tonifier);

            MaComboxBox2.ItemsSource = objectif;

        }

        private void Button_retour(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Liste_Activite(object sender, RoutedEventArgs e)
        {
            ListeActivite listeactivite = new ListeActivite();

            listeactivite.Owner = this;
            listeactivite.WindowStartupLocation = System.Windows.WindowStartupLocation.CenterOwner;

            this.Visibility = Visibility.Hidden;

            listeactivite.ShowDialog();

            this.Visibility = Visibility.Visible;


        }


        private void AjouterProg(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UniqueId))
            {
                MessageBox.Show("Choisissez un identifiant", "Attention Cette identifiant n'est pas alide", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (Manager.GetActivite(UniqueId) != null)
            {
                MessageBox.Show("Cette activité existe déjà entrez une autre valeur !", "Attention UniqueId déjà pris !", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }


            Manager.AjouteProg(new Programme(UniqueId, LeProgramme.NomProg, Jour, LeProgramme._intensite, LeProgramme._objectif));
            Manager.SauvegardeDonnées();

            Close();
        }

        
    }
}
