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
        List<string> weatherConditions = new List<string>() { "Sunny", "Cloudy", "Rainy", "Storms", "Snow" };
        public string predictedForecast;

        Random random = new Random();
        
        // Constructors

        


        // Member Methods

        public void WeatherSelection()
        {
            int weatherSelect = random.Next(1,6); 
            string predictedForecast = weatherSelect[];
            Console.WriteLine(predictedForecast);
        }

        public void Temperature()
        {
            int randomTemp = random.Next(40, 110);
            this.temperature = randomTemp;
            Console.WriteLine(temperature);
        }



    }
}

