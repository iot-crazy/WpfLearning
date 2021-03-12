using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows.Data;

namespace wpfgfx
{

    [ValueConversion(typeof(int), typeof(bool))]
    public class MessageConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (values.Length < 2)
            {
                return "";
            }

            if (values[0] is null || values[1] is null)
            {
                return "";
            }

            string message = values[0].ToString();
            string seconds = values[1].ToString();

            message = message.Replace("{seconds}", seconds);

            return message;

        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
        {
            return null;
        }

    }
}
