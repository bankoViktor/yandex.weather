using System;
using System.ComponentModel;
using System.Globalization;

namespace Yandex.Weather.Converters
{
    public class DayTimeConverter : TypeConverter
    {
        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
        {
            return destinationType == typeof(string);
        }

        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
            switch (value)
            {
                case "d": return "светлое время дня";
                case "n": return "темное время дня";
                default: return value.ToString();
            }
        }
    }
}
