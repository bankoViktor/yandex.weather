using System;
using System.ComponentModel;
using System.Globalization;

namespace Yandex.Weather.Converters
{
    public class WindDirConverter : TypeConverter
    {
        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
        {
            return destinationType == typeof(string);
        }

        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
            switch (value)
            {
                case "nw": return "северо-западное";
                case "n": return "северное";
                case "ne": return "северо-восточное";
                case "e": return "восточное";
                case "se": return "юго-восточное";
                case "s": return "южное";
                case "sw": return "юго-западное";
                case "w": return "западное";
                case "c": return "штиль";
                default: return value.ToString();
            }
        }
    }
}
