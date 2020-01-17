using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSGP
{
    class Weather
    {
        // Member Variables

        public string condition;
        public int temperature;
        public string predictedForecast;
        public string actualWeather;
        public int actualTemperature;

        Random random = new Random();


        // Constructors




        // Member Methods

        public void MasterWeather()
        {
            WeatherSelection();
            ForecastTemperature();
            SetWeather();
            SetTemperature();
        }
        public void WeatherSelection() // random list selection for predicted forecast
        {
            var list = new List<string>() { "Sunny", "Cloudy", "Rainy", "ThunderStorms" };
            int index = random.Next(list.Count);
            predictedForecast = list[index];
        }
        public void ForecastTemperature()
        {
            temperature = random.Next(45, 95);
            Console.WriteLine("The Forecast for today is " + predictedForecast + " & " + temperature + " degrees.");
        }

        public void SetWeather()
        {
            var list = new List<string>() { "Cloudy", "Rainy", "ThunderStorms", "Sunny" };
            int index = random.Next(list.Count);
            actualWeather = list[index];
        }
        public void SetTemperature()
        {
            
            if (actualWeather == "Cloudy")
            {
                actualTemperature = temperature -= 5;
                Console.WriteLine("Todays actual weather conditions are " +actualWeather + " & "+ actualTemperature + " degrees.");
                Console.ReadLine();
            }
            else if (actualWeather == "Sunny")
            {
                actualTemperature = temperature += 10;
                Console.WriteLine("Todays actual weather conditions are " + actualWeather + " & " + actualTemperature + " degrees.");
                Console.ReadLine();
            }
            else if (actualWeather == "Rainy")
            {
                actualTemperature = temperature -= 15;
                Console.WriteLine("Todays actual weather conditions are " + actualWeather + " & " + actualTemperature + " degrees.");
                Console.ReadLine();
            }
            else 
            {
                actualTemperature = temperature -= 13;
                Console.WriteLine("Todays actual weather conditions are " + actualWeather + " & " + actualTemperature + " degrees.");
                Console.ReadLine();
            }

        }
        
    }
}

