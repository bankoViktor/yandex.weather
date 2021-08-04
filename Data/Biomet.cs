using Newtonsoft.Json;

namespace Yandex.Weather.Data
{
    public class Biomet
    {
        /// <summary>
        /// Индекс
        /// </summary>
        [JsonProperty("index")]
        public int Index { get; set; }


        /// <summary>
        /// Состояние
        /// </summary>
        [JsonProperty("condition")]
        public string Сondition { get; set; }
    }
}