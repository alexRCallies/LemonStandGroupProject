using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSGP
{
   public class Customer
    {
        public string name;
        public int age;
        public int chanceToGoToStand;
        public int chanceToBuyprice;
        public int chanceToBuyColdLevel;
        public int chanceToBuySweetLevel;
        public int chanceToBuy;
        public int chanceToBuyAgain;
        
       
        public Customer(string name, int age, int chanceToGoToStand, int chanceToBuyPrice, int chacneToBuySweet, int chanceToBuyColdLevel, int chanceToBuyAgain)
        {
            this.name = name;
            this.age = age;
            this.chanceToGoToStand = chanceToGoToStand;
            this.chanceToBuyprice = chanceToBuyPrice;
            this.chanceToBuySweetLevel = chacneToBuySweet;
            this.chanceToBuyColdLevel = chanceToBuyColdLevel;
            this.chanceToBuyAgain = chanceToBuyAgain;

        }


        
        
    }
}
