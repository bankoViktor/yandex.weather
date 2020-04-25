using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Yandex.Weather
{
    public class Helper
    {
        public static object GetValueByConverter(object cls, string property_name)
        {
            if (cls == null)
                throw new ArgumentNullException(nameof(cls));

            if (string.IsNullOrWhiteSpace(property_name))
                throw new ArgumentNullException(nameof(property_name));

            var pi = cls.GetType().GetProperty(property_name);
            var attr = pi.GetCustomAttribute<TypeConverterAttribute>();

            if (attr != null && !string.IsNullOrEmpty(attr.ConverterTypeName))
            {
                var converter = Activator.CreateInstance(Type.GetType(attr.ConverterTypeName)) as TypeConverter;
                if (converter != null && converter.CanConvertTo(typeof(string)))
                {
                    return converter.ConvertTo(pi.GetValue(cls), typeof(string)) as string;
                }
            }

            return null;
        }
    }
}
