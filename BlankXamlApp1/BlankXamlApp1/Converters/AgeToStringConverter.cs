using System;
using System.Globalization;
using Xamarin.Forms;

namespace BlankXamlApp1.Converters
{
    internal class AgeToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var adult = false;
            int age;
            if (int.TryParse(value.ToString(), out age))
            {
                adult = age >= 18;
            }
            return adult ? "Mayor de edad" : "Menor de edad";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
