using System;

namespace Yandex.Weather
{
    [AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = true)]
    public sealed class YaUnitsAttribute : Attribute
    {
        public string Units { get; }

        public YaUnitsAttribute(string units)
        {
            Units = units;
        }
    }
}