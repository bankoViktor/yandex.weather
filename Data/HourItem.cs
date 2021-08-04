using Newtonsoft.Json;
using System.ComponentModel;
using System.Diagnostics;
using Yandex.Weather.Converters;

namespace Yandex.Weather.Data
{
    [DebuggerDisplay("{Temp}°C")]
    public class HourItem
    {
        /// <summary>
        /// Количество часов от начала текущего дня
        /// </summary>
        [JsonProperty("hour")]
        public int Hour { get; set; }


        /// <summary>
        /// Unixtime 
        /// </summary>
        [JsonProperty("hour_ts")]
        public int HourUnixtime { get; set; }


        /// <summary>
        /// Температура (в градусах Цельсия)
        /// </summary>
        [JsonProperty("temp")]
        public int Temp { get; set; }


        /// <summary>
        /// Ощущаемая температура (в градусах Цельсия)
        /// </summary>
        [JsonProperty("feels_like")]
        public int FeelsLike { get; set; }


        /// <summary>
        /// Код (имя) иконки погоды. Иконка доступна по адресу "https://yastatic.net/weather/i/icons/blueye/color/svg/_значение_из_поля_icon_.svg".
        /// </summary>
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
        [JsonProperty("condition")]
        [TypeConverter(typeof(ConditionConverter))]
        public string Condition { get; set; }


        /// <summary>
        /// Скорость ветра (в м/с)
        /// </summary>
        [JsonProperty("wind_speed")]
        public double WindSpeed { get; set; }


        /// <summary>
        /// Скорость порывов ветра (в м/с)
        /// </summary>
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
        [JsonProperty("wind_dir")]
        [TypeConverter(typeof(WindDirConverter))]
        public string WindDir { get; set; }


        /// <summary>
        /// Давление (в мм рт. ст.)
        /// </summary>
        [JsonProperty("pressure_mm")]
        public int PressureMM { get; set; }


        /// <summary>
        /// Давление (в гектопаскалях)
        /// </summary>
        [JsonProperty("pressure_pa")]
        public int PressurePA { get; set; }


        /// <summary>
        /// Влажность воздуха (в процентах)
        /// </summary>
        [JsonProperty("humidity")]
        public int Humidity { get; set; }

        /// <summary>
        /// UV индекс
        /// </summary>
        [JsonProperty("uv_index")]
        public int UV_Index { get; set; }


        /// <summary>
        /// Температура почвы (в градусах Цельсия)
        /// </summary>
        [JsonProperty("soil_temp")]
        public int SoilTemp { get; set; }


        /// <summary>
        /// Влажность почвы  (в процентах)
        /// </summary>
        [JsonProperty("soil_moisture")]
        public double SoilMoisture { get; set; }


        /// <summary>
        /// Количество осадков (в мм)
        /// </summary>
        [JsonProperty("prec_mm")]
        public double Prec_MM { get; set; }


        /// <summary>
        /// Прогнозируемый период осадков (в минутах)
        /// </summary>
        [JsonProperty("prec_period")]
        public int PrecPeriod { get; set; }


        /// <summary>
        /// Вероятность выпадения осадков (в процентах)
        /// </summary>
        [JsonProperty("prec_prob")]
        public string PrecProb { get; set; }


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
        [JsonProperty("cloudness")]
        [TypeConverter(typeof(CloudnessConverter))]
        public double Cloudness { get; set; }
    }
}