using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSGP
{
    class Mark : Customer
    {
        public Mark()
        {
            this.name = "Mark";
            this.age = 33;
            this.chanceToGoToStand = 4;
           this.chanceToBuy = 7;
            this.chanceToBuyAgain = 3;
            this.chanceToBuyColdLevel = 5;
            this.chanceToBuyprice = 5;
            this.chanceToBuySweetLevel = 5;
        }
    }
}
