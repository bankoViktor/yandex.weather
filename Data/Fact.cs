using Newtonsoft.Json;
using System.ComponentModel;
using Yandex.Weather.Attributes;
using Yandex.Weather.Converters;

namespace Yandex.Weather.Data
{
    /// <summary>
    /// Содержит информацию о погоде на данный момент.
    /// </summary>
    public class Fact
    {
        public override string ToString()
        {
            string wind_dir = Helper.GetValueByConverter(this, nameof(WindDir)) as string;
            return $"{Temp}°C (ощущяется как {FeelsLike}°C) {PressureMM} мм.рт.ст. {Humidity}% {WindSpeed}м/c {wind_dir}";
        }


        /// <summary>
        /// Фактическая температура (в градусах Цельсия).
        /// </summary>
        [DisplayName("Температура фактическая")]
        [Description("Фактическая температура (в градусах Цельсия).")]
        [YaUnits("°C")]
        [JsonProperty("temp")]
        public int Temp { get; set; }


        /// <summary>
        /// Ощущаемая температура (в градусах Цельсия).
        /// </summary>
        [DisplayName("Температура ощущаемая")]
        [Description("Ощущаемая температура (в градусах Цельсия).")]
        [YaUnits("°C")]
        [JsonProperty("feels_like")]
        public int FeelsLike { get; set; }


        /// <summary>
        /// Код (имя) иконки погоды. Иконка доступна по адресу "https://yastatic.net/weather/i/icons/blueye/color/svg/_значение_из_поля_icon_.svg".
        /// </summary>
        [DisplayName("Код иконки погоды")]
        [Description("Код (имя) иконки погоды. Иконка доступна по адресу https://yastatic.net/weather/i/icons/blueye/color/svg/<...>.svg.")]
        [JsonProperty("icon")]
        [TypeConverter(typeof(IconConverter))]
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
        [DisplayName("Погодное описание")]
        [Description("Код расшифровки погодного описания.")]
        [JsonProperty("condition")]
        [TypeConverter(typeof(ConditionConverter))]
        public string Condition { get; set; }


        /// <summary>
        /// Скорость ветра (м/с)
        /// </summary>
        [DisplayName("Скорость ветра")]
        [Description("Скорость ветра (м/с).")]
        [JsonProperty("wind_speed")]
        public double WindSpeed { get; set; }


        /// <summary>
        /// Скорость порывов ветра (м/с)
        /// </summary>
        [DisplayName("Скорость порывов ветра")]
        [Description("Скорость порывов ветра (м/с).")]
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
        [Description("Направление ветра.")]
        [TypeConverter(typeof(WindDirConverter))]
        [JsonProperty("wind_dir")]
        public string WindDir { get; set; }


        /// <summary>
        /// Давление (в мм рт.ст.)
        /// </summary>
        [DisplayName("Давление (мм.рт.ст.)")]
        [Description("Давление.")]
        [YaUnits("мм.рт.ст.")]
        [JsonProperty("pressure_mm")]
        public int PressureMM { get; set; }


        /// <summary>
        /// Давление (в гектопаскалях)
        /// </summary>
        [DisplayName("Давление (гПа)")]
        [Description("Давление (в гектопаскалях).")]
        [YaUnits("гПа")]
        [JsonProperty("pressure_pa")]
        public int PressurePA { get; set; }


        /// <summary>
        /// Влажность воздуха (в процентах)
        /// </summary>
        [DisplayName("Влажность воздуха")]
        [Description("Влажность воздуха (%).")]
        [YaUnits("%")]
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
        [DisplayName("Температура почвы (°C)")]
        [Description("Температура почвы (в градусах Цельсия).")]
        [YaUnits("°C")]
        [JsonProperty("soil_temp")]
        public int SoilTemp { get; set; }


        /// <summary>
        /// Влажность почвы (в процентах)
        /// </summary>
        [DisplayName("Влажность почвы (%)")]
        [Description("Влажность почвы (в процентах)")]
        [YaUnits("%")]
        [JsonProperty("soil_moisture")]
        public double SoilMoisture { get; set; }


        /// <summary>
        /// Светлое или темное время суток. Возможные варианты:
        ///     d — светлое время суток;
        ///     n — темное время суток.
        /// </summary>
        [DisplayName("Светлое или темное время суток")]
        [Description("Светлое или темное время суток.")]
        [TypeConverter(typeof(DayTimeConverter))]
        [JsonProperty("daytime")]
        public string DayTime { get; set; }


        /// <summary>
        /// Флаг полярного дня или ночи
        /// </summary>
        [JsonProperty("polar")]
        public bool Polar { get; set; }


        /// <summary>
        /// Время года в данном населенном пункте. Возможные значения:
        ///     summer — лето;
        ///     autumn — осень;
        ///     winter — зима;
        ///     spring — весна.
        /// </summary>
        [DisplayName("Время года")]
        [Description("Время года в данном населенном пункте.")]
        [TypeConverter(typeof(SeasonConverter))]
        [JsonProperty("season")]
        public string Season { get; set; }


        /// <summary>
        /// Время замера погодных данных в формате Unixtime
        /// </summary>
        [JsonProperty("obs_time")]
        public int ObsTime { get; set; }


        /*
         "accum_prec": {
            "1": 0.1,
            "3": 0.1,
            "7": 0.1
          },
        */
        // TODO Неизвестное поле. Класс Fact, поле 'accum_prec'


        /// <summary>
        /// поле 'source'
        /// </summary>
        // TODO Неизвестное поле. Класс Fact, поле 'source'
        [JsonProperty("source")]
        public string Source { get; set; }


        /// <summary>
        /// Тип осадков. Возможные значения:
        ///     0 — без осадков;
        ///     1 — дождь;
        ///     2 — дождь со снегом;
        ///     3 — снег.
        /// </summary>
        [DisplayName("Тип осадков")]
        [Description("Тип осадков.")]
        [TypeConverter(typeof(PrecTypeConverter))]
        [JsonProperty("prec_type")]
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
        [Description("Сила выпадения осадков.")]
        [TypeConverter(typeof(PrecStrengthConverter))]
        [JsonProperty("prec_strength")]
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
        [Description("Облачность.")]
        [TypeConverter(typeof(CloudnessConverter))]
        [JsonProperty("cloudness")]
        public double Cloudness { get; set; }


        /// <summary>
        /// поле '_mode' 
        /// </summary>
        // TODO Неизвестное поле. Класс Fact, поле '_mode'
        [JsonProperty("_mode")]
        public string Mode { get; set; }
    }
}