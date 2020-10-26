using System;
using System.Collections.Generic;
using System.Text;
using WeatherApp.Commands;
using WeatherApp.Models;
using WeatherApp.Services;

namespace WeatherApp.ViewModels
{
    public class TemperatureViewModel : BaseViewModel
    {
        /// TODO : Ajoutez le code nécessaire pour réussir les tests et répondre aux requis du projet
        /// 

        ITemperatureService TemperatureService;

        public DelegateCommand<string>  GetTempCommand { get; set; }

        public TemperatureModel CurrentTemp { get; set; }

        public void SetTemperatureService(ITemperatureService service)
        {
            TemperatureService = service;
            
        }

        public double ConvertCelsiusInFahrenheit(double expected)
        {
            var actual = expected - 32;
            actual = actual * (5 / 9);
            return actual;
        }

        public double ConvertFahrenheitInCelsius(double expected)
        {
            var actual = expected*(9/5);
            actual = actual + 32;
            return actual;
        }

        public bool CanGetTemp()
        {
            if(TemperatureService == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        
    }
}
