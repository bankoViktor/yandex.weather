using System;
using System.ComponentModel;
using System.Globalization;
using System.Linq;

namespace Yandex.Weather.Converters
{
    public class IconConverter : TypeConverter
    {
        private readonly string[] icons = 
        {
            "bkn_+ra_d",
            "bkn_+ra_n",
            "bkn_+sn_d",
            "bkn_+sn_n",
            "bkn_d",
            "bkn_n",
            "bkn_ra_d",
            "bkn_-ra_d",
            "bkn_ra_n",
            "bkn_-ra_n",
            "bkn_sn_d",
            "bkn_-sn_d",
            "bkn_sn_n",
            "bkn_-sn_n",
            "bl",
            "fg_d",
            "fg_n",
            "ovc",
            "ovc_+ra",
            "ovc_+sn",
            "ovc_gr",
            "ovc_ra",
            "ovc_-ra",
            "ovc_ra_sn",
            "ovc_sn",
            "ovc_-sn",
            "ovc_ts_ra",
            "skc_d",
            "skc_n",
            "bl-",
            "dst",
            "du_st",
            "du_ts",
            "fct_+ra",
            "fct_+sn",
            "fct_ra",
            "fct_-ra",
            "fct_ra_sn",
            "fct_sn",
            "fct_-sn",
            "fct_sn_dwn",
            "fct_sn_rs",
            "fct_ts",
            "fct_ts_ra",
            "ic_air_q",
            "ovc_h",
            "ovc_ra_ice",
            "ovc_ts",
            "ovc_ts_h",
            "smog",
            "strm",
            "vlka"
        };

        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
        {
            return destinationType == typeof(int);
        }

        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            return sourceType == typeof(string);
        }

        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
            if (value is string val)
            {
                var finded = icons.Where(s => s == val);
                if (finded.Count() > 0)
                {
                    var code_icon = Array.IndexOf(icons, finded.First());
                    if (destinationType == typeof(int))
                        return code_icon;
                    else
                        return code_icon.ToString();
                }
            }

            return value;
        }
    }
}
