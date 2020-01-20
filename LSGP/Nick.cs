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
            this.chanceToBuyColdLevel = 5;
            this.chanceToBuyprice = 5;
            this.chanceToBuySweetLevel = 5;
        }
    }
}
