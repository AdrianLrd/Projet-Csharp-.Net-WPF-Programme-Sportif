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
    /// Logique d'interaction pour UCMenu2.xaml
    /// </summary>
    public partial class UCMenu2 : UserControl
    {
        public UCMenu2()
        {
            InitializeComponent();
        }

        private void Button_pdp(object sender, RoutedEventArgs e)
        {
            contentControl.Content = new UCProgrammeSportifPdp2();
        }

        private void Button_pdm(object sender, RoutedEventArgs e)
        {
            contentControl.Content = new UCProgrammeSportifPdm2();
        }

        private void Button_ref(object sender, RoutedEventArgs e)
        {
            contentControl.Content = new UCProgrammeSportifRef2();
        }

        private void Button_st(object sender, RoutedEventArgs e)
        {
            contentControl.Content = new UCProgrammeSportifSt2();
        }
    }
}
