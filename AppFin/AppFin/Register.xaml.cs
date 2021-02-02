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
    /// Logique d'interaction pour Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        public Gestionnaire gestionnaire => (App.Current as App).gestionnaire;

        public Utilisateur Lutilisateur { get; set; }

        public string Mail { get; set; }

        public string ConfirmeMdp { get; set; }
        public Register()
        {
            InitializeComponent();
            Lutilisateur = new Utilisateur(Mail);
            DataContext = this;
        }

        private void Button_retour(object sender, RoutedEventArgs e)
        {
            Login fenetre1 = new Login();
            this.Visibility = Visibility.Hidden;
            fenetre1.Owner = this;
            fenetre1.WindowStartupLocation = System.Windows.WindowStartupLocation.CenterOwner;
            fenetre1.Show();
        }

        private void PremierMotdePasse(object sender, RoutedEventArgs e)
        {
            Lutilisateur.Mdp = MaPremierePassBox.Password;
        }

        private void DeuxiemeMotdePasse(object sender, RoutedEventArgs e)
        {
            ConfirmeMdp = MonDeuxiemePassBox.Password;
        }

        private void AjouterUtilisateur(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Mail))
            {
                MessageBox.Show("Choisissez un Mail", "Attention ce Mail n'est pas valide", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (gestionnaire.GetUtilisateur(Mail) != null)
            {
                MessageBox.Show("Cette utilisateur existe déjà entrez un autre Mail !", "Attention Mail déjà pris !", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if(ConfirmeMdp != Lutilisateur.Mdp)
            {
                MessageBox.Show("Les deux mot de passes ne sont pas les mêmes", "Ecrivez les mêmes mot de passes", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            gestionnaire.AjouteUtilisateur(new Utilisateur(Lutilisateur.Pseudo, Lutilisateur.Mdp, Mail));
            gestionnaire.SauvegardeDonnées();
            MessageBox.Show("Utilisateur bien créer", "Reconnectez vous !", MessageBoxButton.OK);

            Login fenetre2 = new Login();
            this.Visibility = Visibility.Hidden;
            fenetre2.Owner = this;
            fenetre2.WindowStartupLocation = System.Windows.WindowStartupLocation.CenterOwner;
            fenetre2.Show();
        }

        
    }
}
