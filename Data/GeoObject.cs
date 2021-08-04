using Newtonsoft.Json;
using System.ComponentModel;

namespace Yandex.Weather.Data
{
    public class GeoObject
    {
        /// <summary>
        /// Информация о стране
        /// </summary>
        [DisplayName("Страна")]
        [Description("Информация о стране.")]
        [JsonProperty("country")]
        public GeoObjectItem Country { get; set; }


        /// <summary>
        /// Информация о области
        /// </summary>
        [DisplayName("Область/регион/край")]
        [Description("Информация о области/регионе/крайе.")]
        [JsonProperty("province")]
        public GeoObjectItem Province { get; set; }


        /// <summary>
        /// Информация о районе города
        /// </summary>
        [DisplayName("Район города")]
        [Description("Информация о районе города.")]
        [JsonProperty("district")]
        public GeoObjectItem District { get; set; }


        /// <summary>
        /// Информация о городе
        /// </summary>
        [DisplayName("Город")]
        [Description("Информация о городе.")]
        [JsonProperty("locality")]
        public GeoObjectItem Locality { get; set; }


        public override string ToString()
        {
            string result = "";

            // Страна
            if (Country != null && !string.IsNullOrEmpty(Country.Name))
                result += Country.Name;

            // Область
            if (Province != null && !string.IsNullOrEmpty(Province.Name))
                result += ", " + Province.Name;

            // Район города
            if (District != null && !string.IsNullOrEmpty(District.Name))
                result += ", " + District.Name;

            // Город
            if (Locality != null && !string.IsNullOrEmpty(Locality.Name))
                result += ", " + Locality.Name;

            return result;
        }
    }
}