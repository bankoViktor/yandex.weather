using System;
using System.ComponentModel;
using System.Globalization;

namespace Yandex.Weather.Converters
{
    public class CloudnessConverter : TypeConverter
    {
        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
        {
            return destinationType == typeof(string);
        }

        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
            switch (value)
            {
                case 0: return "ясно";
                case 0.25: return "малооблачно";
                case 0.5: return "облачно с прояснениями";
                case 0.75: return "облачно с прояснениями";
                case 1: return "пасмурно";
                default: return value.ToString();
            }
        }
    }
}
