using System;

namespace _05_Temperature
{
    public enum Unit {
        Celcius,
        Fahrenheit
    }

    internal class Temperature
    {
        public double Fahrenheit;
        public double Celcius;
        private Unit celcius;
        private int v;

        public Temperature() {

        }

        public Temperature(Unit scale, int v) {
            if (scale == Unit.Celcius) {
                Celcius = v;
            }
            else {
                Fahrenheit = v;
            }
        }

        internal static double FahrenheitToCelcius(double v) {
            return (v - 32) * (5 / 9.0);
        }

        internal static double CelciusToFahrenheit(double v) {
            return (v * 9 / 5.0) + 32;
        }
    }
}