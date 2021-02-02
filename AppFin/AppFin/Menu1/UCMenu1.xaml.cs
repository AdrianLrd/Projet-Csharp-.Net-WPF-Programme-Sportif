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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AppFin.Menu1
{
    /// <summary>
    /// Logique d'interaction pour UCMenu1.xaml
    /// </summary>
    public partial class UCMenu1 : UserControl
    {
        public UCMenu1()
        {
            InitializeComponent();
        }

        private void Button_pdp(object sender, RoutedEventArgs e)
        {
            contentControl.Content = new UCProgrammeSportifPdp();
        }

        private void Button_pdm(object sender, RoutedEventArgs e)
        {
            contentControl.Content = new UCProgrammeSportifPdm();
        }

        private void Button_ref(object sender, RoutedEventArgs e)
        {
            contentControl.Content = new UCProgrammeSportifRef();
        }

        private void Button_st(object sender, RoutedEventArgs e)
        {
            contentControl.Content = new UCProgrammeSportifSt();
        }
    }
}
