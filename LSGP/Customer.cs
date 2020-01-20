﻿using System;
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
       
        public Customer(string name, int age, int chanceToGoToStand, int chanceToBuyPrice, int chacneToBuySweet, int chanceToBuy, int chanceToBuyAgain)
        {
            this.name = name;
            this.age = age;
            this.chanceToGoToStand = chanceToGoToStand;
            this.chanceToBuyprice = chanceToBuyPrice;
            this.chanceToBuySweetLevel = chacneToBuySweet;
            this.chanceToBuy = chanceToBuy;
            this.chanceToBuyAgain = chanceToBuyAgain;

        }


        public void GoToLemonadeStand()
        {
            Random goToRandom = new Random();
            int arrival = goToRandom.Next(1, 21);
            if(arrival <= chanceToGoToStand)
            {
                Console.WriteLine(name+" arrived at the Lemonade Stand");
            }
            else
            {
                Console.WriteLine(name+" did not got to the stand today");
            }
        }
        
        public void BuyLemonade()
        {
            
            Random randomBasedOnPrice = new Random();
            int priceBuy = randomBasedOnPrice.Next(1, 21);
            Random randomBasedOnSweetness = new Random();
            int sweetBuy = randomBasedOnSweetness.Next(1, 21);
            Random randomBasedOnColdness = new Random();
            int coldBuy = randomBasedOnColdness.Next(1, 21);
            if(priceBuy <= chanceToBuyprice)
            {
                Console.WriteLine(name+" thinks the price is fair");
                if(sweetBuy <= chanceToBuySweetLevel)
                {
                    Console.WriteLine(name+" thinks the recipe is good");
                    if(coldBuy<=chanceToBuyColdLevel)
                    {
                        Console.WriteLine(name+" thinks the tempature of the lemonade is good");
                        BuyAgain();
                    }
                    else
                    {
                        Console.WriteLine(name+" thinks the tempature of the lemonade is bad");
                    }
                }
                else
                {
                    Console.WriteLine(name+ " thinks the recipe is bad");
                }
            }
            else
            {
                Console.WriteLine(name+ " thinks the price is unfair");
            }
        }
        public void BuyAgain()
        {
            Random buyAgain = new Random();
            int again = buyAgain.Next(1, 11);
            if(again <= chanceToBuyAgain)
            {
                BuyLemonade();
            }
            else
            {
                Console.WriteLine(name+ " is satisfied");
            }
        }
        public void MasterCustomerBuyLemonade()
        {
            GoToLemonadeStand();
            BuyLemonade();
        }
    }
}
