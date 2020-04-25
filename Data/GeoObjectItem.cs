using Newtonsoft.Json;
using System.ComponentModel;
using System.Diagnostics;

namespace Yandex.Weather.Data
{
    [DebuggerDisplay("{Name,nq} ({Id})")]
    public class GeoObjectItem
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        [DisplayName("Идентификатор")]
        [Description("Числовой идентификатор текущего объекта.")]
        [JsonProperty("id")]
        public int Id { get; set; }


        /// <summary>
        /// Наименование ассрциированное с данным идентификатором
        /// </summary>
        [DisplayName("Наименование")]
        [Description("Наименование текущего объекта.")]
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}