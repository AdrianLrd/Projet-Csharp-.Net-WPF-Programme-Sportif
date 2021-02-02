using Modele;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace AppFin.windows
{
    /// <summary>
    /// Logique d'interaction pour AjouterActivite.xaml
    /// </summary>
    public partial class AjouterActivite : Window
    {
        public Gestionnaire Manager => (System.Windows.Application.Current as App).gestionnaire;

        public Activite LActivite { get; set; }

        public string UniqueId { get; set; }
        public AjouterActivite()
        {
            InitializeComponent();
            LActivite = new Activite(UniqueId);
            DataContext = this;
        }

        private void textbox1_previewtextinput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
        }

        private void Button_retour(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void AjouterActivité(object sender, RoutedEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(UniqueId))
            {
                MessageBox.Show("Choisissez un identifiant", "Attention Cette identifiant n'est pas alide", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if(Manager.GetActivite(UniqueId) != null)
            {
                MessageBox.Show("Cette activité existe déjà entrez une autre valeur !", "Attention UniqueId déjà pris !", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }


            Manager.AjouterActivite(new Activite(UniqueId, LActivite.NomAct, LActivite.Duree, LActivite.NbSerie, LActivite.NbRep, LActivite.Desc));
            Manager.SauvegardeDonnées();

            Close();
        }
    }
}

