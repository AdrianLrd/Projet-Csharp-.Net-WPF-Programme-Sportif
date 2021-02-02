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
    /// Logique d'interaction pour UCAdresse.xaml
    /// </summary>
    public partial class UCAdresse : UserControl
    {
        public UCAdresse()
        {
            InitializeComponent();
        }

        public string MaTextBlock
        {
            set
            {
                laTextBlock.Text = value;
            }
        }

        public string TextBox
        {
            set
            {
                laTextBox.Text = value;
            }
        }
    }
}
