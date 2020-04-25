using Newtonsoft.Json;
using System;
using System.ComponentModel;
using Yandex.Weather.Converters;

namespace Yandex.Weather.Data
{
    /// <summary>
    /// Содержит данные прогноза погоды.
    /// </summary>
    public class Forecast
    {
        public override string ToString()
        {
            DateTime dateTime = DateTime.Parse(Date);
            return dateTime.ToString("dd, ddd");
        }


        /// <summary>
        /// Время прогноза
        /// </summary>
        [DisplayName("Дата")]
        [Description("Время прогноза.")]
        [JsonProperty("date")]
        public string Date { get; set; }


        /// <summary>
        /// Время прогноза в Unixtime
        /// </summary>
        [JsonProperty("date_ts")]
        public int DateUnixtime { get; set; }


        /// <summary>
        /// Номер недели
        /// </summary>
        [DisplayName("Номер недели")]
        [Description("Номер недели прогноза.")]
        [JsonProperty("week")]
        public int Week { get; set; }


        /// <summary>
        /// Время восхода Солнца, локальное время
        /// </summary>
        [DisplayName("Время начала восхода солнца")]
        [Description("Время восхода Солнца, локальное время.")]
        [JsonProperty("sunrise")]
        public string SunRise { get; set; }


        /// <summary>
        /// Время заката Солнца, локальное время
        /// </summary>
        [DisplayName("Время заката солнца")]
        [JsonProperty("sunset")]
        public string SunSet { get; set; }


        /// <summary>
        /// Начало восхода
        /// </summary>
        // TODO проверить Forecast - Начало восхода
        [DisplayName("Время начала восхода")]
        [JsonProperty("rise_begin")]
        public string RiseBegin { get; set; }


        /// <summary>
        /// Конец заката
        /// </summary>
        // TODO проверить Forecast - Конец заката
        [DisplayName("Время конца заката")]
        [JsonProperty("set_end")]
        public string SetEnd { get; set; }


        /// <summary>
        /// Код фазы луны. Возможные значения:
        ///     0 — полнолуние;
        ///     1-3 — убывающая Луна;
        ///     4 — последняя четверть;
        ///     5-7 — убывающая Луна;
        ///     8 — новолуние;
        ///     9-11 — растущая Луна;
        ///     12 — первая четверть;
        ///     13-15 — растущая Луна.
        /// </summary>
        [DisplayName("Код фазы луны")]
        [JsonProperty("moon_code")]
        [TypeConverter(typeof(MoonCodeConverter))]
        public int MoonCode { get; set; }


        /// <summary>
        /// Текстовый код для фазы Луны. Возможные значения:
        ///     full-moon — полнолуние;
        ///     decreasing-moon — убывающая Луна;
        ///     last-quarter — последняя четверть;
        ///     new-moon — новолуние;
        ///     growing-moon — растущая Луна;
        ///     first-quarter — первая четверть;
        /// </summary>
        [DisplayName("Фаза луны")]
        [JsonProperty("moon_text")]
        public string MoonText { get; set; }


        /// <summary>
        /// Прогнозы по времени суток и 12-часовые прогнозы. 
        /// Содержит поля, различающиеся типом прогноза:
        ///     night — прогноз на ночь;
        ///     morning — прогноз на утро;
        ///     day — прогноз на день;
        ///     evening — прогноз на вечер;
        ///     day_short — 12-часовой прогноз на день;
        ///     night_short — 12-часовой прогноз на ночь текущих суток.
        /// </summary>
        [DisplayName("По частям дня")]
        [Description("Прогнозы по времени суток и 12-часовые прогнозы.")]
        [JsonProperty("parts")]
        public Parts Parts { get; set; }


        /// <summary>
        /// Информация по каждому часу дня
        /// </summary>
        [DisplayName("По часам дня")]
        [Description("Информация по каждому часу дня.")]
        [JsonProperty("hours")]
        public HourItem[] Hours { get; set; }


        /// <summary>
        /// поле 'biomet'
        /// </summary>
        [JsonProperty("biomet")]
        public Biomet Biomet { get; set; }
    }
}
