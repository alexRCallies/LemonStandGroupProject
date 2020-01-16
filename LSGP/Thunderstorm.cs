using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSGP
{
    class Thunderstorm : Weather
    {
        // Member Variables

        



        //member methods

        public override void Temperature()
        {
            
            int randomTemp = random.Next(55, 85);
            temperature = randomTemp += 5;
            base.Temperature();

        }
    }
}
