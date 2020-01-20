using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSGP
{
    class Sasha : Customer
    {
        public Sasha()
        {
            this.name = "Sasha";
            this.age = 12;
            this.chanceToGoToStand = 7;
            this.chanceToBuy = 8;
           this.chanceToBuyAgain = 2;
        }
    }
}
