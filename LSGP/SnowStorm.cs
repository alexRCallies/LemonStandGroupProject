using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSGP
{
    class SnowStorm : Weather
    {
        // Member Variables

        



        //member methods

        public override void Temperature()
        {
           
            int randomTemp = random.Next(25, 40);
            temperature = randomTemp -=5;
           
            base.Temperature();

        }
    }
}
