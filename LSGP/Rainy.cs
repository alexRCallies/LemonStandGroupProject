using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSGP
{
    class Rainy : Weather
    {
        // Member Variables


        


        //member methods

        public override void Temperature()
        {
          
            int randomTemp = random.Next(55, 70);
            temperature = randomTemp -= 5;
            base.Temperature();

        }
    }
}
