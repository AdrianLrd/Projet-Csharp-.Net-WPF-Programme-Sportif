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

namespace AppFin
{
    /// <summary>
    /// Logique d'interaction pour UCProgrammeSportifPdm2.xaml
    /// </summary>
    public partial class UCProgrammeSportifPdm2 : UserControl
    {
        public UCProgrammeSportifPdm2()
        {
            InitializeComponent();
        }

        private void P1_Click(object sender, RoutedEventArgs e)
        {
            windows.InfoProg voirprog = new windows.InfoProg(13);
            voirprog.ShowDialog();
        }

        private void P2_Click(object sender, RoutedEventArgs e)
        {
            windows.InfoProg voirprog = new windows.InfoProg(14);
            voirprog.ShowDialog();
        }

        private void P3_Click(object sender, RoutedEventArgs e)
        {
            windows.InfoProg voirprog = new windows.InfoProg(15);
            voirprog.ShowDialog();
        }
    }
}
