using Newtonsoft.Json;
using System;
using System.Globalization;
using System.Net.Http;
using System.Threading.Tasks;

namespace Yandex.Weather
{
    /// <summary>
    /// Класс запроса погоды от сервиса Яндекс.Погода.
    /// </summary>
    public class YaWeatherProvider
    {
        public string Endpoint;
        public string Key;
        private readonly HttpClient Http;

        /// <summary>
        /// Создает экземпляр класса с помощью которого можно запросить погоду от сервера
        /// </summary>
        /// <param name="endpoint">URL адрес конечной точки сервиса Яндекс.Погода.</param>
        /// <param name="key">Ключ в виде строки, содержащей буквы и цифры, необходим для доступа к Яндекс API.</param>
        public YaWeatherProvider(string endpoint, string key)
        {
            Endpoint = endpoint;
            Key = key;
            Http = new HttpClient();
            //Http.DefaultRequestHeaders.Add("X-Yandex-API-Key", Key);
        }

        /// <summary>
        /// Осуществляет запрос для одного населенного пункта расположенного по переденным координатам
        /// </summary>
        /// <param name="lat">Широта (десятичные градусы, например: 48.707103)</param>
        /// <param name="lon">Долгота (десятичные градусы, например: 44.516939)</param>
        /// <param name="extra">Флаг влияющий на полноту запрашиваемых данных</param>
        /// <returns>Возвращает класс, содержащий данные о погоде</returns>
        public async Task<YaWeatherData> GetWeatherAsync(double lat, double lon, bool extra = true)
        {
            string uri = Endpoint + '?'
                + "lat=" + lat.ToString("00.0000000", new CultureInfo("en-US", false))
                + "&lon=" + lon.ToString("00.0000000", new CultureInfo("en-US", false))
                + "&extra=" + extra.ToString();

            return await SendRequestAsync(uri);
        }

        /// <summary>
        /// Осуществляет запрос для одного населенного пункта по его идентификатору
        /// </summary>
        /// <param name="geioid">Индивидуальный числовой код населенного пункта</param>
        /// <param name="extra">Флаг влияющий на полноту запрашиваемых данных</param>
        /// <returns>Возвращает класс, содержащий данные о погоде</returns>
        public async Task<YaWeatherData> GetWeatherAsync(int geioid, bool extra = true)
        {
            string uri = $"{Endpoint}?geoid={geioid.ToString()}&extra={extra.ToString()}";
            return await SendRequestAsync(uri);
        }

        private async Task<YaWeatherData> SendRequestAsync(string uri)
        {
            Http.DefaultRequestHeaders.Clear();
            Http.DefaultRequestHeaders.Add("X-Yandex-API-Key", Key);

            try
            {
                string response = await Http.GetStringAsync(uri);

                if (string.IsNullOrWhiteSpace(response))
                    throw new Exception();

                return JsonConvert.DeserializeObject<YaWeatherData>(response);
            }
            catch (HttpRequestException e)
            {
                throw new Exception(e.Message, e);
            }
        }
    }
}
