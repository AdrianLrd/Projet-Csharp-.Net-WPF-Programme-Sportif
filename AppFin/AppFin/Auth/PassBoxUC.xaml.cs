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

namespace AppFin.Auth
{
    /// <summary>
    /// Logique d'interaction pour PassBoxUC.xaml
    /// </summary>
    public partial class PassBoxUC : UserControl
    {
        public PassBoxUC()
        {
            InitializeComponent();
        }

        public string PassText
        {
            set
            {
                PassTextBlock.Text = value;
            }
        }

        public string PassBox
        {
            set
            {
                MaPassBox.Password = value;
            }
        }
    }
}
