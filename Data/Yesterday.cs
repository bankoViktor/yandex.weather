using Newtonsoft.Json;
using System.ComponentModel;
using System.Diagnostics;
using Yandex.Weather.Attributes;

namespace Yandex.Weather.Data
{
    [DebuggerDisplay("{Temp}°C")]
    public class Yesterday
    {
        /// <summary>
        /// Температура за предыдущий день (в градусах Цельсия)
        /// </summary>
        [DisplayName("Температура за предыдущий день")]
        [Description("Температура за предыдущий день (в градусах Цельсия).")]
        [YaUnits("°C")]
        [JsonProperty("temp")]
        public int Temp { get; set; }
    }
}
