using System;
using System.ComponentModel;
using System.Globalization;

namespace Yandex.Weather.Converters
{
    public class ConditionConverter : TypeConverter
    {
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            return sourceType == typeof(string);
        }


        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
        {
            return destinationType == typeof(string);
        }

        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
            switch (value)
            {
                case "clear": return "ясно";
                case "partly-cloudy": return "малооблачно";
                case "cloudy": return "облачно с прояснениями";
                case "overcast": return "пасмурно";
                case "partly-cloudy-and-light-rain": return "небольшой дождь";
                case "partly-cloudy-and-rain": return "дождь";
                case "cast-and-rain": return "сильный дождь";
                case "overcast-thunderstorms-with-rain": return "сильный дождь, гроза";
                case "cloudy-and-light-rain": return "небольшой дождь";
                case "overcast-and-light-rain": return "небольшой дождь";
                case "cloudy-and-rain": return "дождь";
                case "overcast-and-wet-snow": return "дождь со снегом";
                case "partly-cloudy-and-light-snow": return "небольшой снег";
                case "partly-cloudy-and-snow": return "снег";
                case "overcast-and-snow": return "снегопад";
                case "cloudy-and-light-snow": return "небольшой снег";
                case "overcast-and-light-snow": return "небольшой снег";
                case "cloudy-and-snow": return "снег";
                default: return value.ToString();
            }
        }
    }
}
