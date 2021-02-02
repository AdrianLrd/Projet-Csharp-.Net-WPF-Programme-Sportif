using System.Windows;
using System.Windows.Controls;
using Modele;

namespace AppFin
{
    /// <summary>
    /// Logique d'interaction pour ListeActivite.xaml
    /// </summary>
    public partial class ListeActivite : Window
    {
        public Gestionnaire gestionnaire => (App.Current as App).gestionnaire;

        public ListeActivite()
        {
            InitializeComponent();
            DataContext = gestionnaire;
        }

        private void Button_retour(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void AjoutActivite(object sender, RoutedEventArgs e)
        {
            windows.AjouterActivite Newactiv = new windows.AjouterActivite();
            this.Visibility = Visibility.Hidden;

            Newactiv.Owner = this;
            Newactiv.WindowStartupLocation = System.Windows.WindowStartupLocation.CenterOwner;



            Newactiv.ShowDialog();

            this.Visibility = Visibility.Visible;
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            InfoAct voiract = new InfoAct(listbox.SelectedItem as Activite);
            voiract.ShowDialog();
        }
    }
}
