using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MenuPre : Window
    {
        public MenuPre()
        {
            InitializeComponent();
        }

        private void Retour_Main(object sender, RoutedEventArgs e)
        {
            MainWindow mainwindow = new MainWindow();
            this.Visibility = Visibility.Hidden;

            mainwindow.Owner = this;
            mainwindow.WindowStartupLocation = System.Windows.WindowStartupLocation.CenterOwner;



            mainwindow.Show();
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
