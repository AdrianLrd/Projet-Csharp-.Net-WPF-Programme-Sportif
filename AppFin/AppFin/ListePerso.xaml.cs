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
    /// Logique d'interaction pour ListePerso.xaml
    /// </summary>
    public partial class ListePerso : Window
    {
        public Gestionnaire gestionnaire => (App.Current as App).gestionnaire;

        public string UniqID { get; set; }

        public ListePerso()
        {
            InitializeComponent();
            DataContext = gestionnaire;
        }

        private void Retour_Main(object sender, RoutedEventArgs e)
        {
            MainWindow mainwindow = new MainWindow();
            this.Visibility = Visibility.Hidden;

            mainwindow.Owner = this;
            mainwindow.WindowStartupLocation = System.Windows.WindowStartupLocation.CenterOwner;



            mainwindow.Show();
        }



        private void AjoutProg(object sender, RoutedEventArgs e)
        {
            MenuPerso menuperso = new MenuPerso();
            this.Visibility = Visibility.Hidden;

            menuperso.Owner = this;
            menuperso.WindowStartupLocation = System.Windows.WindowStartupLocation.CenterOwner;



            menuperso.ShowDialog();


            this.Visibility = Visibility.Visible;
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            InfoProg2 voirprog = new InfoProg2(listbox.SelectedItem as Programme);
            voirprog.ShowDialog();
        }
    }
}
