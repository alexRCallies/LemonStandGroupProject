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
        public double dailyProfitOrLoss = 0;
        public double weeklyProfitLoss;
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
        public void DisplayProfitOrLoss()
        {
            if(dailyProfitOrLoss > 0)
            {
                Console.WriteLine("You made $"+dailyProfitOrLoss);
            }
            else if(dailyProfitOrLoss < 0)
            {
                Console.WriteLine("You lost $"+dailyProfitOrLoss);
            }
            else
            {
                Console.WriteLine("You went even");
            }
        }
        public void DisplayWeeklyProfitOrLoss()
        {
            if(weeklyProfitLoss >0)
            {
                Console.WriteLine("You made $" + weeklyProfitLoss);
            }
            else if(weeklyProfitLoss <0)
            {
                Console.WriteLine("You lost $"+weeklyProfitLoss);
            }
            else
            {
                Console.WriteLine("You went even");
            }
        }

    }
}
