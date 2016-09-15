using System;

namespace _05_Temperature
{
    internal class TemperatureFactory
    {
        internal static ITemperature Get(Unit scale) {
            ITemperature obj = null;
            switch (scale) {
                case Unit.Celcius :
                    obj = new Celcius(); break;
                case Unit.Fahrenheit:
                    obj = new Fahrenheit(); break;
            }

            return obj;
        }
    }
}