using Newtonsoft.Json;
using System.ComponentModel;

namespace Yandex.Weather.Data
{
    /// <summary>
    /// Прогнозы по времени суток и 12-часовые прогнозы
    /// </summary>
    public class Parts
    {
        /// <summary>
        /// Прогноз на ночь.
        /// </summary>
        [DisplayName("Ночь")]
        [Description("Прогноз на ночь. Начало ночного периода соответствует времени начала суток. Для указания предстоящей ночной температуры используйте объект ночного прогноза следующего дня.")]
        [JsonProperty("night")]
        public Part Night { get; set; }


        /// <summary>
        /// Прогноз на утро.
        /// </summary>
        [DisplayName("Утро")]
        [Description("Прогноз на утро.")]
        [JsonProperty("morning")]
        public Part Morning { get; set; }


        /// <summary>
        /// Прогноз на день.
        /// </summary>
        [DisplayName("День")]
        [Description("Прогноз на день.")]
        [JsonProperty("day")]
        public Part Day { get; set; }


        /// <summary>
        /// Прогноз на вечер.
        /// </summary>
        [DisplayName("Вечер")]
        [Description("Прогноз на вечер.")]
        [JsonProperty("evening")]
        public Part Evening { get; set; }


        /// <summary>
        /// 12-часовой прогноз на день.
        /// </summary>
        [DisplayName("День. 12-часовой")]
        [Description("12-часовой прогноз на день.")]
        [JsonProperty("day_short")]
        public ShortPart DayShort { get; set; }


        /// <summary>
        /// 12-часовой прогноз на ночь текущих суток.
        /// </summary>
        [DisplayName("Ночь. 12-часовой")]
        [Description("12-часовой прогноз на ночь текущих суток.")]
        [JsonProperty("night_short")]
        public ShortPart NightShort { get; set; }
    }
}
