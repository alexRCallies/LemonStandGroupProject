using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSGP
{
    class Cloudy : Weather
    {
        // Member Variables

        



        //member methods

        public override void Temperature()
        {
           
            int randomTemp = random.Next(65, 95);
            temperature = randomTemp -= 5;
            base.Temperature();

        }
    }
}
