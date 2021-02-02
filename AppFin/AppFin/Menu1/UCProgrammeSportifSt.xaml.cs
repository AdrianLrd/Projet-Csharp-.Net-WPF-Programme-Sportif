using MaterialDesignThemes.Wpf;
using Modele;
using System.Windows;
using System.Windows.Controls;


namespace AppFin.Menu1
{
    /// <summary>
    /// Logique d'interaction pour UCProgrammeSportifSt.xaml
    /// </summary>
    public partial class UCProgrammeSportifSt : UserControl
    {        
        public UCProgrammeSportifSt()
        {
            InitializeComponent();
        }

        private void P1_Click(object sender, RoutedEventArgs e)
        {
            windows.InfoProg voirprog = new windows.InfoProg(10);
            voirprog.ShowDialog();

        }

        private void P2_Click(object sender, RoutedEventArgs e)
        {
            windows.InfoProg voirprog = new windows.InfoProg(11);
            voirprog.ShowDialog();
            
        }

        private void P3_Click(object sender, RoutedEventArgs e)
        {
            windows.InfoProg voirprog = new windows.InfoProg(12);
            voirprog.ShowDialog();
            
        }
    }
}
