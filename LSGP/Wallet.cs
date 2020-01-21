using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSGP
{
   public class Wallet
    {

        private double money = 100;

        public double Money
        {
            get
            {
                return money;
            }
            set
            {
                money = value;
            }
        }
        public Wallet()
        {
          
        }
             public void NewBalance()
        {
            Console.WriteLine("Balance: $"+money);
        }

    }
}
