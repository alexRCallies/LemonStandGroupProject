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
        public int actualTemperature;
        List<string> weatherConditions;

        Random random = new Random();


        // Constructors




        // Member Methods  OPEN CLOSED PRINCIPLE - ALL METHODS CAN BE EXPENDED IF NEEDED TO EXPAND GAME PLAY  - Nick

        public void Masterforecast()
        {
            WeatherSelection();
            ForecastTemperature();
        }
        public void ActualWeather()
        {
            SetWeather();
            SetTemperature();
        }
        
        public void WeatherSelection() // SINGLE RESPONSIBILITY EXAMPLE - random list selection for forecast weather condition - 
        {
            weatherConditions = new List<string>() { "Sunny", "Cloudy", "Rainy", "ThunderStorms" };
            int index = random.Next(weatherConditions.Count);
            predictedForecast = weatherConditions[index];
        }
        public void ForecastTemperature()  // SINGLE RESPONSIBILITY EXAMPLE - random used to select the forcast temp - 
        {
            temperature = random.Next(45, 95);
            Console.WriteLine("The Forecast for today is " + predictedForecast + " & " + temperature + " degrees.");
        }

        public void SetWeather()  // SINGLE RESPONSIBILITY EXAMPLE - random used to select the actual weather -
        {
            weatherConditions = new List<string>() { "Cloudy", "Rainy", "ThunderStorms", "Sunny" };
            int index = random.Next(weatherConditions.Count);
            condition = weatherConditions[index];
        }
        public void SetTemperature()  // SINGLE RESPONSIBILITY EXAMPLE - sets the actual temp based on the actual weather condition - Nick
        {
            
            if (condition == "Cloudy")
            {
                actualTemperature = temperature -= 5;
                Console.WriteLine("Todays actual weather conditions are " + condition + " & "+ actualTemperature + " degrees.");
                Console.ReadLine();
            }
            else if (condition == "Sunny")
            {
                actualTemperature = temperature += 10;
                Console.WriteLine("Todays actual weather conditions are " + condition + " & " + actualTemperature + " degrees.");
                Console.ReadLine();
            }
            else if (condition == "Rainy")
            {
                actualTemperature = temperature -= 15;
                Console.WriteLine("Todays actual weather conditions are " + condition + " & " + actualTemperature + " degrees.");
                Console.ReadLine();
            }
            else 
            {
                actualTemperature = temperature -= 13;
                Console.WriteLine("Todays actual weather conditions are " + condition + " & " + actualTemperature + " degrees.");
                Console.ReadLine();
            }

        }
        
    }
}

