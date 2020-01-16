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


        

        // Constructors

        


        // Member Methods


         public void WeatherSelection() // random list selection for predicted forecast
         {
            Random random = new Random();
            var list = new List<string>() { "Sunny", "Cloudy", "Rainy", "ThunderStorms", "SnowStorms" };
            int index = random.Next(list.Count);
            predictedForecast = list[index];
            Console.WriteLine("Todays Forecast Weather " + predictedForecast);
                        
         }


    }
}

