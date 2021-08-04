using System;
using System.ComponentModel;
using System.Globalization;

namespace Yandex.Weather.Converters
{
    public class SeasonConverter : TypeConverter
    {
        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
        {
            return destinationType == typeof(string);
        }

        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
            switch (value)
            {
                case "summer": return "лето";
                case "autumn": return "осень";
                case "winter": return "зима";
                case "spring": return "весна";
                default: return value.ToString();
            }
        }
    }
}
