using Newtonsoft.Json;
using System.ComponentModel;
using System.Diagnostics;
using Yandex.Weather.Attributes;
using Yandex.Weather.Converters;

namespace Yandex.Weather.Data
{
    /// <summary>
    /// Прогноз погоды на часть дня (ночь/утро/день/вечер).
    /// </summary>
    [DebuggerDisplay("{TempAvg}°C")]
    public class Part
    {
        /// <summary>
        /// поле '_source'
        /// </summary>
        // TODO Неизвестное поле. Класс Part, поле '_source'
        [JsonProperty("_source")]
        public string Source { get; set; }

        /// <summary>
        /// Минимальная температура (в градусах Цельсия)
        /// </summary>
        [DisplayName("Температура минимальная")]
        [Description("Минимальная температура (°C)")]
        [YaUnits("°C")]
        [JsonProperty("temp_min")]
        public int TempMin { get; set; }

        /// <summary>
        /// Максимальная температура (в градусах Цельсия)
        /// </summary>
        [DisplayName("Температура максимальная")]
        [Description("Максимальная температура (°C)")]
        [YaUnits("°C")]
        [JsonProperty("temp_max")]
        public int TempMax { get; set; }

        /// <summary>
        /// Средняя температура (в градусах Цельсия)
        /// </summary>
        [DisplayName("Температура средняя")]
        [Description("Средняя температура (в градусах Цельсия)")]
        [YaUnits("°C")]
        [JsonProperty("temp_avg")]
        public int TempAvg { get; set; }

        /// <summary>
        /// Ощущаемая температура (в градусах Цельсия)
        /// </summary>
        [DisplayName("Температура ощущаемая")]
        [Description("Ощущаемая температура (в градусах Цельсия)")]
        [YaUnits("°C")]
        [JsonProperty("feels_like")]
        public int FeelsLike { get; set; }

        /// <summary>
        /// Код (имя) иконки погоды. Иконка доступна по адресу "https://yastatic.net/weather/i/icons/blueye/color/svg/_значение_из_поля_icon_.svg".
        /// </summary>
        [DisplayName("Код иконки погоды")]
        [Description("Код (имя) иконки погоды. Иконка доступна по адресу https://yastatic.net/weather/i/icons/blueye/color/svg/<...>.svg")]
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
        [Description("Код расшифровки погодного описания")]
        [JsonProperty("condition")]
        [TypeConverter(typeof(ConditionConverter))]
        public string Condition { get; set; }

        /// <summary>
        /// Светлое или темное время суток
        /// </summary>
        [DisplayName("Светлое или темное время суток")]
        [Description("Светлое или темное время суток")]
        [JsonProperty("daytime")]
        public string DayTime { get; set; }

        /// <summary>
        /// Признак полярного дня или ночи
        /// </summary>
        [DisplayName("Признак полярного дня или ночи")]
        [Description("Признак полярного дня или ночи")]
        [JsonProperty("polar")]
        public bool Polar { get; set; }

        /// <summary>
        /// Скорость ветра (м/с)
        /// </summary>
        [DisplayName("Скорость ветра")]
        [Description("Скорость ветра (м/с)")]
        [YaUnits("м/с")]
        [JsonProperty("wind_speed")]
        public double WindSpeed { get; set; }

        /// <summary>
        /// Скорость порывов ветра (м/с)
        /// </summary>
        [DisplayName("Скорость порывов ветра")]
        [Description("Скорость порывов ветра (м/с)")]
        [YaUnits("м/с")]
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
        [Description("Направление ветра")]
        [TypeConverter(typeof(WindDirConverter))]
        [JsonProperty("wind_dir")]
        public string WindDir { get; set; }

        /// <summary>
        /// Давление (в мм рт.ст.)
        /// </summary>
        [DisplayName("Давление (мм.рт.ст.)")]
        [Description("Давление")]
        [YaUnits("мм.рт.ст.")]
        [JsonProperty("pressure_mm")]
        public int PressureMM { get; set; }

        /// <summary>
        /// Давление (в гектопаскалях)
        /// </summary>
        [DisplayName("Давление (гПа)")]
        [Description("Давление (в гектопаскалях)")]
        [YaUnits("гПа")]
        [JsonProperty("pressure_pa")]
        public int PressurePA { get; set; }

        /// <summary>
        /// Влажность воздуха (в процентах)
        /// </summary>
        [DisplayName("Влажность воздуха")]
        [Description("Влажность воздуха (%)")]
        [YaUnits("%")]
        [JsonProperty("humidity")]
        public int Humidity { get; set; }

        /// <summary>
        /// UI индекс
        /// </summary>
        [JsonProperty("uv_index")]
        public int UV_Index { get; set; }

        /// <summary>
        /// Температура почвы (в градусах Цельсия)
        /// </summary>
        [DisplayName("Температура почвы (°C)")]
        [Description("Температура почвы (в градусах Цельсия)")]
        [YaUnits("°C")]
        [JsonProperty("soil_temp")]
        public int SoilTemp { get; set; }

        /// <summary>
        /// Влажность почвы (в процентах)
        /// </summary>
        [DisplayName("Влажность почвы (%)")]
        [Description("Температура почвы (в градусах Цельсия)")]
        [YaUnits("%")]
        [JsonProperty("soil_moisture")]
        public double SoilMoisture { get; set; }

        /// <summary>
        /// Количество осадков (в мм)
        /// </summary>
        [DisplayName("Прогнозируемое количество осадков (мм)")]
        [Description("Прогнозируемое количество осадков (в мм)")]
        [YaUnits("мм")]
        [JsonProperty("prec_mm")]
        public double Prec_MM { get; set; }

        /// <summary>
        /// Прогнозируемый период осадков (в минутах)
        /// </summary>
        [DisplayName("Прогнозируемый период осадков (мин)")]
        [Description("Прогнозируемый период осадков (в минутах)")]
        [YaUnits("мин")]
        [JsonProperty("prec_period")]
        public int PrecPeriod { get; set; }

        /// <summary>
        /// Вероятность выпадения осадков (в процентах)
        /// </summary>
        [DisplayName("Вероятность выпадения осадков (%)")]
        [Description("Вероятность выпадения осадков (в процентах)")]
        [YaUnits("%")]
        [JsonProperty("prec_prob")]
        public int PrecProb { get; set; }

        /// <summary>
        /// Тип осадков. Возможные значения:
        ///     0 — без осадков;
        ///     1 — дождь;
        ///     2 — дождь со снегом;
        ///     3 — снег.
        /// </summary>
        [DisplayName("Тип осадков")]
        [Description("Тип осадков")]
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
        [Description("Сила выпадения осадков")]
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
        [Description("Облачность")]
        [TypeConverter(typeof(CloudnessConverter))]
        [JsonProperty("cloudness")]
        public double Cloudness { get; set; }
    }
}
