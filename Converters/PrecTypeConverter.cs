using System;
using System.ComponentModel;
using System.Globalization;

namespace Yandex.Weather.Converters
{
    class PrecTypeConverter : TypeConverter
    {
        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
        {
            return destinationType == typeof(string);
        }

        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
            switch (value)
            {
                case 0: return "без осадков";
                case 1: return "дождь со снегом";
                case 3: return "снег";
                default: return value.ToString();
            }
        }
    }
}
