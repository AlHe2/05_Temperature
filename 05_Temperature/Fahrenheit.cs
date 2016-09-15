using System;

namespace _05_Temperature
{
    internal class Fahrenheit : ITemperature
    {
        public double Convert(double v) {
            return (v * 9.0) / 5 + 32;
        }
    }
}