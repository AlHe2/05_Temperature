using System;

namespace _05_Temperature
{
    internal class Celcius : ITemperature
    {
        public double Convert(double v) {
            return ((v - 32) * 5.0) / 9;
        }
    }
}