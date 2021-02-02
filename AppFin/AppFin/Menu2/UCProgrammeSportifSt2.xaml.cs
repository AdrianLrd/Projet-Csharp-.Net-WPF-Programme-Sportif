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
    /// Logique d'interaction pour UCProgrammeSportifSt2.xaml
    /// </summary>
    public partial class UCProgrammeSportifSt2 : UserControl
    {
        public UCProgrammeSportifSt2()
        {
            InitializeComponent();
        }

        private void P1_Click(object sender, RoutedEventArgs e)
        {
            windows.InfoProg voirprog = new windows.InfoProg(22);
            voirprog.ShowDialog();
        }

        private void P2_Click(object sender, RoutedEventArgs e)
        {
            windows.InfoProg voirprog = new windows.InfoProg(23);
            voirprog.ShowDialog();
        }

        private void P3_Click(object sender, RoutedEventArgs e)
        {
            windows.InfoProg voirprog = new windows.InfoProg(24);
            voirprog.ShowDialog();
        }
    }
}
