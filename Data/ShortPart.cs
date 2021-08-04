using Newtonsoft.Json;
using System.ComponentModel;
using System.Diagnostics;
using Yandex.Weather.Converters;

namespace Yandex.Weather.Data
{
    /// <summary>
    /// 12-часовой прогноз.
    /// </summary>
    [DebuggerDisplay("{Temp}°C")]
    public class ShortPart
    {
        /// <summary>
        /// Температура (в градусах Цельсия)
        /// </summary>
        [DisplayName("Температура (°C)")]
        [JsonProperty("temp")]
        public int Temp { get; set; }


        /// <summary>
        /// Ощущаемая температура (в градусах Цельсия)
        /// </summary>
        [DisplayName("Ощущаемая температура (°C)")]
        [JsonProperty("feels_like")]
        public int FeelsLike { get; set; }


        /// <summary>
        /// Код (имя) иконки погоды. Иконка доступна по адресу "https://yastatic.net/weather/i/icons/blueye/color/svg/_значение_из_поля_icon_.svg".
        /// </summary>
        [DisplayName("Код иконки погоды")]
        [JsonProperty("icon")]
        public string Icon { get; set; }


        /// <summary>
        /// Код расшифровки погодного описания. Возможные значения:
        ///     clear — ясно;
        ///     partly-cloudy — малооблачно;
        ///     cloudy — облачно с прояснениями;
        ///     overcast — пасмурно;
        ///     partly-cloudy-and-light-rain — небольшой дождь;
        ///     partly-cloudy-and-rain — дождь;
        ///     overcast-and-rain — сильный дождь;
        ///     overcast-thunderstorms-with-rain — сильный дождь, гроза;
        ///     cloudy-and-light-rain — небольшой дождь;
        ///     overcast-and-light-rain — небольшой дождь;
        ///     cloudy-and-rain — дождь;
        ///     overcast-and-wet-snow — дождь со снегом;
        ///     partly-cloudy-and-light-snow — небольшой снег;
        ///     partly-cloudy-and-snow — снег;
        ///     overcast-and-snow — снегопад;
        ///     cloudy-and-light-snow — небольшой снег;
        ///     overcast-and-light-snow — небольшой снег;
        ///     cloudy-and-snow — снег.
        /// </summary>
        [DisplayName("Код расшифровки погодного описания")]
        [JsonProperty("condition")]
        [TypeConverter(typeof(ConditionConverter))]
        public string Condition { get; set; }


        /// <summary>
        /// Скорость ветра (м/с)
        /// </summary>
        [DisplayName("Скорость ветра (м/с)")]
        [JsonProperty("wind_speed")]
        public double WindSpeed { get; set; }


        /// <summary>
        /// Скорость порывов ветра (м/с)
        /// </summary>
        [DisplayName("Скорость порывов ветра (м/с)")]
        [JsonProperty("wind_gust")]
        public double WindGust { get; set; }


        /// <summary>
        /// Направление ветра. Возможные значения:
        ///     nw — северо-западное;
        ///     n — северное;
        ///     ne — северо-восточное;
        ///     e — восточное;
        ///     se — юго-восточное;
        ///     s — южное;
        ///     sw — юго-западное;
        ///     w — западное;
        ///     с — штиль.
        /// </summary>
        [DisplayName("Направление ветра")]
        [JsonProperty("wind_dir")]
        [TypeConverter(typeof(WindDirConverter))]
        public string WindDir { get; set; }


        /// <summary>
        /// Давление (в мм рт.ст.)
        /// </summary>
        [DisplayName("Давление (мм рт.ст.)")]
        [JsonProperty("pressure_mm")]
        public int PressureMM { get; set; }


        /// <summary>
        /// Давление (в гектопаскалях)
        /// </summary>
        [DisplayName("Давление (гПа)")]
        [JsonProperty("pressure_pa")]
        public int PressurePA { get; set; }


        /// <summary>
        /// Влажность воздуха (в процентах)
        /// </summary>
        [DisplayName("Влажность воздуха (%)")]
        [JsonProperty("humidity")]
        public int Humidity { get; set; }


        /// <summary>
        /// Тип осадков. Возможные значения:
        ///     0 — без осадков;
        ///     1 — дождь;
        ///     2 — дождь со снегом;
        ///     3 — снег.
        /// </summary>
        [DisplayName("Тип осадков")]
        [JsonProperty("prec_type")]
        [TypeConverter(typeof(PrecTypeConverter))]
        public int PrecType { get; set; }


        /// <summary>
        /// Сила выпадения осадков. Возможные значения:
        ///     0 — без осадков;
        ///     0.25 — слабый дождь/слабый снег;
        ///     0.5 — дождь/снег;
        ///     0.75 — сильный дождь/сильный снег;
        ///     1 — сильный ливень/очень сильный снег.
        /// </summary>
        [DisplayName("Сила выпадения осадков")]
        [JsonProperty("prec_strength")]
        [TypeConverter(typeof(PrecStrengthConverter))]
        public double PrecStrength { get; set; }


        /// <summary>
        /// Облачность. Возможные значения: 
        ///     0 — ясно; 
        ///     0.25 — малооблачно; 
        ///     0.5 — облачно с прояснениями; 
        ///     0.75 — облачно с прояснениями; 
        ///     1 — пасмурно.
        /// </summary>
        [DisplayName("Облачность")]
        [JsonProperty("cloudness")]
        [TypeConverter(typeof(CloudnessConverter))]
        public double Cloudness { get; set; }
    }
}