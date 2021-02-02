using System.Windows;
using System.Windows.Controls;

namespace AppFin.Menu1
{
    /// <summary>
    /// Logique d'interaction pour UCProgrammeSportifPdp.xaml
    /// </summary>
    public partial class UCProgrammeSportifPdp : UserControl
    {
        public UCProgrammeSportifPdp()
        {
            InitializeComponent();
        }

        private void P1_Click(object sender, RoutedEventArgs e)
        {
            windows.InfoProg voirprog = new windows.InfoProg(4);
            voirprog.ShowDialog();
        }

        private void P2_Click(object sender, RoutedEventArgs e)
        {
            windows.InfoProg voirprog = new windows.InfoProg(5);
            voirprog.ShowDialog();
        }

        private void P3_Click(object sender, RoutedEventArgs e)
        {
            windows.InfoProg voirprog = new windows.InfoProg(6);
            voirprog.ShowDialog();
        }
    }
}
