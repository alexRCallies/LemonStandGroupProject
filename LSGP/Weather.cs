using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSGP
{
   public class Weather
    {
        // Member Variables

        public string condition;
        public int temperature;
        public string predictedForecast;
        public int actualTemperature;
        public List<string> weatherConditions;

        Random random = new Random();


        // Constructors




        // Member Methods  OPEN CLOSED PRINCIPLE - ALL METHODS CAN BE EXPENDED IF NEEDED TO EXPAND GAME PLAY  - Nick

        public void MasterForecast()
        {
            ForecastWeather();
            ForecastTemperature();
        }
        public void ActualDayWeather()
        {
            ActualConditions();
            ActualTemperature();
        }
        
        public void ForecastWeather() // SINGLE RESPONSIBILITY EXAMPLE - random list selection for forecast weather condition - 
        {
            weatherConditions = new List<string>() { "Sunny", "Cloudy", "Rainy", "Thunder Storms" };
            int index = random.Next(weatherConditions.Count);
            predictedForecast = weatherConditions[index];
            
        }
        public void ForecastTemperature()  // SINGLE RESPONSIBILITY EXAMPLE - random used to select the forcast temp - 
        {
            temperature = random.Next(45, 95);
            Console.WriteLine("\nThe Forecast for today is " + predictedForecast + " & " + temperature + " degrees.");
        }

        public void ActualConditions()  // SINGLE RESPONSIBILITY EXAMPLE - random used to select the actual weather -
        {
            weatherConditions = new List<string>() { "Cloudy", "Rainy", "Thunder Storms", "Sunny" };

            int index = random.Next(weatherConditions.Count-1);
            condition = weatherConditions[index];

        }
        public void ActualTemperature()  // SINGLE RESPONSIBILITY EXAMPLE - sets the actual temp based on the actual weather condition - Nick
        {

            if (condition == "Cloudy")
            {
                actualTemperature = temperature -= 5;
                Console.WriteLine("Todays actual weather conditions are " + condition + " & " + actualTemperature + " degrees.");

            }
            else if (condition == "Sunny")
            {
                actualTemperature = temperature += 10;
                Console.WriteLine("Todays actual weather conditions are " + condition + " & " + actualTemperature + " degrees.");

            }
            else if (condition == "Rainy")
            {
                actualTemperature = temperature -= 15;
                Console.WriteLine("Todays actual weather conditions are " + condition + " & " + actualTemperature + " degrees.");
                
            }
            else
            {
                actualTemperature = temperature -= 13;
                Console.WriteLine("Todays actual weather conditions are " + condition + " & " + actualTemperature + " degrees.");
               
            }

        }
        
    }
}

