using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.Diagnostics;
using Yandex.Weather.Converters;

namespace Yandex.Weather
{
    /// <summary>
    /// Клас содержащий данные о погоде полученные от Яндекс.ру с помощью класса YaWeatherProvider
    /// </summary>
    [DebuggerDisplay("{GeoObject.Locality.Name,nq} ({Info.GeoID}) {NowDateTime,nq}")]
    public class YaWeatherData
    {
        /// <summary>
        /// Время сервера в формате Unixtime
        /// </summary>
        [JsonProperty("now")]
        public int NowUnixtime { get; set; }


        /// <summary>
        /// Время сервера в UTC
        /// </summary>
        [DisplayName("Время сервера (UTC)")]
        [Description("Время погодного сервера в формате UTC.")]
        [JsonProperty("now_dt")]
        public string NowDateTime { get; set; }


        /// <summary>
        /// Объект информации о населенном пункте
        /// </summary>
        [JsonProperty("info")]
        public Info Info { get; set; }


        /// <summary>
        /// Объект фактической информации о погоде
        /// </summary>
        [DisplayName("Фактическая информация")]
        [Description("Фактическая информация о погоде на текущий день.")]
        [JsonProperty("fact")]
        public Fact Fact { get; set; }


        /// <summary>
        /// Объект прогнозной информации о погоде
        /// </summary>
        [DisplayName("Прогнозная информация")]
        [Description("Прогнозная информация о погоде на несколько дней.")]
        [JsonProperty("forecasts")]
        public Forecast[] Forecasts { get; set; }


        /// <summary>
        /// Информация о местоположении
        /// </summary>
        [DisplayName("Информации о населенном пункте")]
        [Description("Информации о населенном пункте, для которого запрошена погодная информация.")]
        [JsonProperty("geo_object")]
        public GeoObject GeoObject { get; set; }


        /// <summary>
        /// Температура предыдущего дня
        /// </summary>
        [DisplayName("Вчерашняя погода")]
        [Description("За предыдущий день.")]
        [JsonProperty("yesterday")]
        public Yesterday Yesterday { get; set; }
    }


    [DebuggerDisplay("Lat: {Latitude}, Lon: {Longitude}")]
    public class Info
    {
        /// <summary>
        /// поле 'f'
        /// </summary>
        // TODO Неизвестное поле. Класс Info, поле 'f'
        [JsonProperty("f")]
        public bool F { get; set; }


        /// <summary>
        /// поле 'n'
        /// </summary>
        // TODO Неизвестное поле. Класс Info, поле 'n'
        [JsonProperty("n")]
        public bool N { get; set; }


        /// <summary>
        /// поле 'nr'
        /// </summary>
        // TODO Неизвестное поле. Класс Info, поле 'nr'
        [JsonProperty("nr")]
        public bool NR { get; set; }


        /// <summary>
        /// поле 'ns'
        /// </summary>
        // TODO Неизвестное поле. Класс Info, поле 'ns'
        [JsonProperty("ns")]
        public bool NS { get; set; }


        /// <summary>
        /// поле 'nsr'
        /// </summary>
        // TODO Неизвестное поле. Класс Info, поле 'nsr'
        [JsonProperty("nsr")]
        public bool NSR { get; set; }


        /// <summary>
        /// поле 'p'
        /// </summary>
        // TODO Неизвестное поле. Класс Info, поле 'p'
        [JsonProperty("p")]
        public bool P { get; set; }


        /// <summary>
        /// Широта (в градусах, десятичный формат)
        /// </summary>
        [JsonProperty("lat")]
        public double Latitude { get; set; }


        /// <summary>
        /// Долгота (в градусах, десятичный формат)
        /// </summary>
        [JsonProperty("lon")]
        public double Longitude { get; set; }


        /// <summary>
        /// Гео-идентификатор населенного пункта в сервисе Яндекс.Погода
        /// </summary>
        [JsonProperty("geoid")]
        public int GeoID { get; set; }


        /// <summary>
        /// Название населенного пункта (транслитом)
        /// </summary>
        [JsonProperty("slug")]
        public string Slug { get; set; }


        /// <summary>
        /// поле 'zoom'
        /// </summary>
        // TODO Неизвестное поле. Класс Info, поле 'zoom'
        [JsonProperty("zoom")]
        public int Zoom { get; set; }


        /// <summary>
        /// Информация о часовом поясе
        /// </summary>
        [JsonProperty("tzinfo")]
        public TZInfo TzInfo { get; set; }


        /// <summary>
        /// Норма давления для данной координаты (в мм рт.ст.)
        /// </summary>
        [JsonProperty("def_pressure_mm")]
        public int DefPressureMM { get; set; }


        /// <summary>
        /// Норма давления для данной координаты (в гектопаскалях)
        /// </summary>
        [JsonProperty("def_pressure_pa")]
        public int DefPressurePA { get; set; }


        /// <summary>
        /// поле '_h'
        /// </summary>
        // TODO Неизвестное поле. Класс Info, поле '_h'
        [JsonProperty("_h")]
        public bool H { get; set; }


        /// <summary>
        /// Страница населенного пункта на сайте Яндекс.Погода
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }
    }


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


    public class GeoObject
    {
        /// <summary>
        /// Информация о стране
        /// </summary>
        [DisplayName("Страна")]
        [Description("Информация о стране.")]
        [JsonProperty("country")]
        public GeoObjectItem Country { get; set; }


        /// <summary>
        /// Информация о области
        /// </summary>
        [DisplayName("Область/регион/край")]
        [Description("Информация о области/регионе/крайе.")]
        [JsonProperty("province")]
        public GeoObjectItem Province { get; set; }


        /// <summary>
        /// Информация о районе города
        /// </summary>
        [DisplayName("Район города")]
        [Description("Информация о районе города.")]
        [JsonProperty("district")]
        public GeoObjectItem District { get; set; }


        /// <summary>
        /// Информация о городе
        /// </summary>
        [DisplayName("Город")]
        [Description("Информация о городе.")]
        [JsonProperty("locality")]
        public GeoObjectItem Locality { get; set; }


        public override string ToString()
        {
            string result = "";

            // Страна
            if (Country != null && !string.IsNullOrEmpty(Country.Name))
                result += Country.Name;

            // Область
            if (Province != null && !string.IsNullOrEmpty(Province.Name))
                result += ", " + Province.Name;

            // Район города
            if (District != null && !string.IsNullOrEmpty(District.Name))
                result += ", " + District.Name;

            // Город
            if (Locality != null && !string.IsNullOrEmpty(Locality.Name))
                result += ", " + Locality.Name;

            return result;
        }
    }


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


    /// <summary>
    /// Объект фактической информации о погоде
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


    /// <summary>
    /// Объект прогнозной информации о погоде
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


    /// <summary>
    /// Прогнозы по времени суток и 12-часовые прогнозы
    /// </summary>
    public class Parts
    {
        /// <summary>
        /// Прогноз на ночь
        /// </summary>
        [DisplayName("Ночь")]
        [Description("Прогноз на ночь. Начало ночного периода соответствует времени начала суток. Для указания предстоящей ночной температуры используйте объект ночного прогноза следующего дня.")]
        [JsonProperty("night")]
        public Part Night { get; set; }


        /// <summary>
        /// Прогноз на утро
        /// </summary>
        [DisplayName("Утро")]
        [Description("Прогноз на утро.")]
        [JsonProperty("morning")]
        public Part Morning { get; set; }


        /// <summary>
        /// Прогноз на день
        /// </summary>
        [DisplayName("День")]
        [Description("Прогноз на день.")]
        [JsonProperty("day")]
        public Part Day { get; set; }


        /// <summary>
        /// Прогноз на вечер
        /// </summary>
        [DisplayName("Вечер")]
        [Description("Прогноз на вечер.")]
        [JsonProperty("evening")]
        public Part Evening { get; set; }


        /// <summary>
        /// 12-часовой прогноз на день
        /// </summary>
        [DisplayName("День. 12-часовой")]
        [Description("12-часовой прогноз на день.")]
        [JsonProperty("day_short")]
        public ShortPart DayShort { get; set; }


        /// <summary>
        /// 12-часовой прогноз на ночь текущих суток
        /// </summary>
        [DisplayName("Ночь. 12-часовой")]
        [Description("12-часовой прогноз на ночь текущих суток.")]
        [JsonProperty("night_short")]
        public ShortPart NightShort { get; set; }
    }


    [DebuggerDisplay("{Temp}°C")]
    public class ShortPart
    {
        /// <summary>
        /// Температура (в градусах Цельсия)
        /// </summary>
        [DisplayName("Температура (°C)")]
        [JsonProperty("temp")]
        public int Temp { get; set; }


        /// <summary>
        /// Ощущаемая температура (в градусах Цельсия)
        /// </summary>
        [DisplayName("Ощущаемая температура (°C)")]
        [JsonProperty("feels_like")]
        public int FeelsLike { get; set; }


        /// <summary>
        /// Код (имя) иконки погоды. Иконка доступна по адресу "https://yastatic.net/weather/i/icons/blueye/color/svg/_значение_из_поля_icon_.svg".
        /// </summary>
        [DisplayName("Код иконки погоды")]
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
        [DisplayName("Код расшифровки погодного описания")]
        [JsonProperty("condition")]
        [TypeConverter(typeof(ConditionConverter))]
        public string Condition { get; set; }


        /// <summary>
        /// Скорость ветра (м/с)
        /// </summary>
        [DisplayName("Скорость ветра (м/с)")]
        [JsonProperty("wind_speed")]
        public double WindSpeed { get; set; }


        /// <summary>
        /// Скорость порывов ветра (м/с)
        /// </summary>
        [DisplayName("Скорость порывов ветра (м/с)")]
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
        [JsonProperty("wind_dir")]
        [TypeConverter(typeof(WindDirConverter))]
        public string WindDir { get; set; }


        /// <summary>
        /// Давление (в мм рт.ст.)
        /// </summary>
        [DisplayName("Давление (мм рт.ст.)")]
        [JsonProperty("pressure_mm")]
        public int PressureMM { get; set; }


        /// <summary>
        /// Давление (в гектопаскалях)
        /// </summary>
        [DisplayName("Давление (гПа)")]
        [JsonProperty("pressure_pa")]
        public int PressurePA { get; set; }


        /// <summary>
        /// Влажность воздуха (в процентах)
        /// </summary>
        [DisplayName("Влажность воздуха (%)")]
        [JsonProperty("humidity")]
        public int Humidity { get; set; }


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
        [DisplayName("Сила выпадения осадков")]
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
        [DisplayName("Облачность")]
        [JsonProperty("cloudness")]
        [TypeConverter(typeof(CloudnessConverter))]
        public double Cloudness { get; set; }
    }


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