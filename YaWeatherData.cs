using Newtonsoft.Json;
using System.ComponentModel;
using System.Diagnostics;
using Yandex.Weather.Data;

namespace Yandex.Weather
{
    /// <summary>
    /// Содержит погодную информацию, полученную от сервиса Яндекс.Погода с помощью класса <see cref="YaWeatherProvider"/>.
    /// </summary>
    [DebuggerDisplay("{GeoObject.Locality.Name,nq} ({Info.GeoID}) {NowDateTime,nq}")]
    public class YaWeatherData
    {
        /// <summary>
        /// Время сервера в формате Unixtime
        /// </summary>
        [JsonProperty("now")]
        public int NowUnixtime { get; set; }


        /// <summary>
        /// Время сервера в UTC
        /// </summary>
        [DisplayName("Время сервера (UTC)")]
        [Description("Время погодного сервера в формате UTC.")]
        [JsonProperty("now_dt")]
        public string NowDateTime { get; set; }


        /// <summary>
        /// Объект информации о населенном пункте
        /// </summary>
        [JsonProperty("info")]
        public Info Info { get; set; }


        /// <summary>
        /// Объект фактической информации о погоде
        /// </summary>
        [DisplayName("Фактическая информация")]
        [Description("Фактическая информация о погоде на текущий день.")]
        [JsonProperty("fact")]
        public Fact Fact { get; set; }


        /// <summary>
        /// Объект прогнозной информации о погоде
        /// </summary>
        [DisplayName("Прогнозная информация")]
        [Description("Прогнозная информация о погоде на несколько дней.")]
        [JsonProperty("forecasts")]
        public Forecast[] Forecasts { get; set; }


        /// <summary>
        /// Информация о местоположении
        /// </summary>
        [DisplayName("Информации о населенном пункте")]
        [Description("Информации о населенном пункте, для которого запрошена погодная информация.")]
        [JsonProperty("geo_object")]
        public GeoObject GeoObject { get; set; }


        /// <summary>
        /// Температура предыдущего дня
        /// </summary>
        [DisplayName("Вчерашняя погода")]
        [Description("За предыдущий день.")]
        [JsonProperty("yesterday")]
        public Yesterday Yesterday { get; set; }
    }
}