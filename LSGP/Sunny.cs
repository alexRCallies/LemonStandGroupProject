using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSGP
{
    class Sunny : Weather
    {
        // Member Variables

        


        //member methods

        public override void Temperature()
        {
            
            int randomTemp = random.Next(70, 110);
            temperature = randomTemp;
            actualTemperature = temperature += 5;
            base.Temperature();
            
        }


    }
}
