using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSGP
{
    class Madonna : Customer
    {
        public Madonna()
        {
            this.name = "Madonna";
            this.age = 72;
            this.chanceToGoToStand = 3;
            this.chanceToBuy = 7;
            this.chanceToBuyAgain = 7;
        }
    }
}
