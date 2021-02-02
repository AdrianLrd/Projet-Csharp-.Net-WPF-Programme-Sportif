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
using Modele;

namespace AppFin
{
    /// <summary>
    /// Logique d'interaction pour Login.xaml
    /// </summary>
    public partial class Login : Window
    {

        public Gestionnaire gestionnaire => (App.Current as App).gestionnaire;

        public Utilisateur Lutilisateur { get; set; }

        public string Mail { get; set; }

        public string Mdp { get; set; }

        public Login()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            Register objRegister = new Register();
            this.Visibility = Visibility.Hidden;

            objRegister.Owner = this;
            objRegister.WindowStartupLocation = System.Windows.WindowStartupLocation.CenterOwner;
            objRegister.ShowDialog();
        }

        private void Retour_Main(object sender, RoutedEventArgs e)
        {
            MainWindow mainwindow = new MainWindow();
            this.Visibility = Visibility.Hidden;

            mainwindow.Owner = this;
            mainwindow.WindowStartupLocation = System.Windows.WindowStartupLocation.CenterOwner;



            mainwindow.Show();
        }

        private void MotdePasse(object sender, RoutedEventArgs e)
        {
            Mdp = MaPassBoxMDP.Password;
        }

        private void Authentification(object sender, RoutedEventArgs e)
        {
            if(!gestionnaire.Login(Mail, Mdp))
            {
                MessageBox.Show("Email ou mot de passe incorrect", "Login impossible", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            MessageBox.Show("Login correcte !", "Merci",MessageBoxButton.OK);

            gestionnaire.UtilisateurConnecte = gestionnaire.GetUtilisateur(Mail);

            MainWindow mainwindow = new MainWindow();
            this.Visibility = Visibility.Hidden;

            mainwindow.Owner = this;
            mainwindow.WindowStartupLocation = System.Windows.WindowStartupLocation.CenterOwner;



            mainwindow.Show();
        }
    }
}
