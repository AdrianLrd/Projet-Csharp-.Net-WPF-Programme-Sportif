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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AppFin.Menu1
{
    /// <summary>
    /// Logique d'interaction pour UCProgrammeSportifRef.xaml
    /// </summary>
    public partial class UCProgrammeSportifRef : UserControl
    {
        public UCProgrammeSportifRef()
        {
            InitializeComponent();
        }

        private void P1_Click(object sender, RoutedEventArgs e)
        {
            windows.InfoProg voirprog = new windows.InfoProg(7);
            voirprog.ShowDialog();
        }

        private void P2_Click(object sender, RoutedEventArgs e)
        {
            windows.InfoProg voirprog = new windows.InfoProg(8);
            voirprog.ShowDialog();
        }

        private void P3_Click(object sender, RoutedEventArgs e)
        {
            windows.InfoProg voirprog = new windows.InfoProg(9);
            voirprog.ShowDialog();
        }
    }
}
