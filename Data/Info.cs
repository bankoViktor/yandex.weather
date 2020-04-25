using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.Diagnostics;
using Yandex.Weather.Converters;

namespace Yandex.Weather.Data
{
    /// <summary>
    /// Содержит информацию о населенном пункте.
    /// </summary>
    [DebuggerDisplay("Lat: {Latitude}, Lon: {Longitude}")]
    public class Info
    {
        /// <summary>
        /// поле 'f'
        /// </summary>
        // TODO Неизвестное поле. Класс Info, поле 'f'
        [JsonProperty("f")]
        public bool F { get; set; }


        /// <summary>
        /// поле 'n'
        /// </summary>
        // TODO Неизвестное поле. Класс Info, поле 'n'
        [JsonProperty("n")]
        public bool N { get; set; }


        /// <summary>
        /// поле 'nr'
        /// </summary>
        // TODO Неизвестное поле. Класс Info, поле 'nr'
        [JsonProperty("nr")]
        public bool NR { get; set; }


        /// <summary>
        /// поле 'ns'
        /// </summary>
        // TODO Неизвестное поле. Класс Info, поле 'ns'
        [JsonProperty("ns")]
        public bool NS { get; set; }


        /// <summary>
        /// поле 'nsr'
        /// </summary>
        // TODO Неизвестное поле. Класс Info, поле 'nsr'
        [JsonProperty("nsr")]
        public bool NSR { get; set; }


        /// <summary>
        /// поле 'p'
        /// </summary>
        // TODO Неизвестное поле. Класс Info, поле 'p'
        [JsonProperty("p")]
        public bool P { get; set; }


        /// <summary>
        /// Широта (в градусах, десятичный формат)
        /// </summary>
        [JsonProperty("lat")]
        public double Latitude { get; set; }


        /// <summary>
        /// Долгота (в градусах, десятичный формат)
        /// </summary>
        [JsonProperty("lon")]
        public double Longitude { get; set; }


        /// <summary>
        /// Гео-идентификатор населенного пункта в сервисе Яндекс.Погода
        /// </summary>
        [JsonProperty("geoid")]
        public int GeoID { get; set; }


        /// <summary>
        /// Название населенного пункта (транслитом)
        /// </summary>
        [JsonProperty("slug")]
        public string Slug { get; set; }


        /// <summary>
        /// поле 'zoom'
        /// </summary>
        // TODO Неизвестное поле. Класс Info, поле 'zoom'
        [JsonProperty("zoom")]
        public int Zoom { get; set; }


        /// <summary>
        /// Информация о часовом поясе
        /// </summary>
        [JsonProperty("tzinfo")]
        public TZInfo TzInfo { get; set; }


        /// <summary>
        /// Норма давления для данной координаты (в мм рт.ст.)
        /// </summary>
        [JsonProperty("def_pressure_mm")]
        public int DefPressureMM { get; set; }


        /// <summary>
        /// Норма давления для данной координаты (в гектопаскалях)
        /// </summary>
        [JsonProperty("def_pressure_pa")]
        public int DefPressurePA { get; set; }


        /// <summary>
        /// поле '_h'
        /// </summary>
        // TODO Неизвестное поле. Класс Info, поле '_h'
        [JsonProperty("_h")]
        public bool H { get; set; }


        /// <summary>
        /// Страница населенного пункта на сайте Яндекс.Погода
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}