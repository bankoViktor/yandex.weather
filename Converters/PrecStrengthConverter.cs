using System;
using System.ComponentModel;
using System.Globalization;

namespace Yandex.Weather.Converters
{
    public class PrecStrengthConverter : TypeConverter
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
                case 0.25: return "слабый дождь/слабый снег";
                case 0.5: return "дождь/снег";
                case 0.75: return "сильный дождь/сильный снег";
                case 1: return "сильный ливень/очень сильный снег";
                default: return value.ToString();
            }
        }
    }
}
