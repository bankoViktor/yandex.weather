using Newtonsoft.Json;
using System.Diagnostics;

namespace Yandex.Weather.Data
{
    /// <summary>
    /// Информация о часовом поясе.
    /// </summary>
    [DebuggerDisplay("{Name,nq} GMT{Abbreviature,nq}")]
    public class TZInfo
    {
        /// <summary>
        /// Название часового пояса
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }


        /// <summary>
        /// Сокращенное название часового пояса
        /// </summary>
        [JsonProperty("abbr")]
        public string Abbreviature { get; set; }


        /// <summary>
        /// Часовой пояс в секундах от UTC
        /// </summary>
        [JsonProperty("offset")]
        public int Offset { get; set; }


        /// <summary>
        /// Признак летнего времени
        /// </summary>
        [JsonProperty("dst")]
        public bool IsSummerTime { get; set; }
    }
}