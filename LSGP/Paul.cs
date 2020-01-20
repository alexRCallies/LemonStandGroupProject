using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSGP
{
    class Paul:Customer
    {
        public Paul()
        {
            this.name = "Paul";
            this.age = 45;
            this.chanceToGoToStand = 4;
            this.chanceToBuy = 4;
            this.chanceToBuyAgain = 4;
            this.chanceToBuyColdLevel = 5;
            this.chanceToBuyprice = 5;
            this.chanceToBuySweetLevel = 5;
        }
    }
}
