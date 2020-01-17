using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSGP
{
   public class Wallet
    {
        public double money;
        public Wallet()
        {
            money = 20;
        }
             public void NewBalance()
        {
            Console.WriteLine("Balance: $"+money);
        }

    }
}
