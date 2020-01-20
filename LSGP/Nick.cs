using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSGP
{
    class Nick:Customer
    {
        public Nick()
        {
            this.name = "Nick";
            this.age = 41;
            this.chanceToGoToStand = 7;
            this.chanceToBuy = 6;
            this.chanceToBuyAgain = 5;
        }
    }
}
