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
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public Gestionnaire gestionnaire => (App.Current as App).gestionnaire;

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void Menu_prefait(object sender, RoutedEventArgs e)
        {
            MenuPre menupre = new MenuPre();

            this.Visibility = Visibility.Hidden;

            menupre.Owner = this;
            menupre.WindowStartupLocation = System.Windows.WindowStartupLocation.CenterOwner;

            menupre.Show();

        }

        private void Menu_salle(object sender, RoutedEventArgs e)
        {
            MenuSalle menusalle = new MenuSalle();

            this.Visibility = Visibility.Hidden;

            menusalle.Owner = this;
            menusalle.WindowStartupLocation = System.Windows.WindowStartupLocation.CenterOwner;

            menusalle.Show();
        }

        private void Liste_Perso(object sender, RoutedEventArgs e)
        {

            if(gestionnaire.UtilisateurConnecte.Mail == "rien")
            {
                Login login = new Login();
                this.Visibility = Visibility.Hidden;

                login.Owner = this;
                login.WindowStartupLocation = System.Windows.WindowStartupLocation.CenterOwner;
                login.Show();
            }
            else
            {

                ListePerso listeperso = new ListePerso();
                this.Visibility = Visibility.Hidden;

                listeperso.Owner = this;
                listeperso.WindowStartupLocation = System.Windows.WindowStartupLocation.CenterOwner;

                listeperso.Show();
                
            } 
        }

        private void Button_Ident(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            this.Visibility = Visibility.Hidden;

            login.Owner = this;
            login.WindowStartupLocation = System.Windows.WindowStartupLocation.CenterOwner;
            login.Show();
        }

    }
}
