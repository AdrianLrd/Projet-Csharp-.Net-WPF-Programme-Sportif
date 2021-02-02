using System;
using Modele;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows;
using System.Windows.Data;

namespace AppFin
{
    public class IdentificationButtunToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo cultur)
        {
            if (value != "rien")
            {
                return Visibility.Collapsed;
            }
            else return Visibility.Visible;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo cultur)
        {
            return null;
        }
    }
}
