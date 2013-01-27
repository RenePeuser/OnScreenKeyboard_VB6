using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace OnScreenkeyboard_VB6.Test
{
    [ValueConversion(typeof(String), typeof(Visibility))]
    public class StringVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (Equals(value, "")) return Visibility.Collapsed;
            return Visibility.Visible;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}
