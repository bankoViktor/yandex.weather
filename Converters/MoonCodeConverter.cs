using System;
using System.ComponentModel;
using System.Globalization;

namespace Yandex.Weather.Converters
{
    public class MoonCodeConverter : TypeConverter
    {
        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
        {
            return destinationType == typeof(string);
        }

        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
            switch (value)
            {
                case 0: return "полнолуние";
                case 1:
                case 2:
                case 3: return "убывающая Луна";
                case 4: return "последняя четверть";
                case 5:
                case 6:
                case 7: return "убывающая Луна";
                case 8: return "новолуние";
                case 9:
                case 10:
                case 11: return "растущая Луна";
                case 12: return "первая четверть";
                case 13:
                case 14:
                case 15: return "растущая Луна";
                default: return value.ToString();
            }
        }
    }
}
