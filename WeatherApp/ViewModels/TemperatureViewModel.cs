using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherApp.ViewModels
{
    public class TemperatureViewModel : BaseViewModel
    {
        /// TODO : Ajoutez le code nécessaire pour réussir les tests et répondre aux requis du projet
        public object ConvertCelsiusInFahrenheit(double expected)
        {
            var actual = expected - 32;
            actual = actual * (5 / 9);
            return actual;
        }

        public object ConvertFahrenheitInCelsius(double expected)
        {
            var actual = expected*(9/5);
            actual = actual + 32;
            return actual;
        }

        public object GetTempCommand()
        {
            return null;
        }
    }
}
