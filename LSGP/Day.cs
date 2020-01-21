using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSGP
{
    public class Day : Weather
    {
        // member variables

        public int dayCounter = 7;
        public Player player;
        Customer aaron;
        Customer alex;
        Customer david;
        Customer leah;
        Customer lisa;
        Customer madonna;
        Customer mark;
        Customer mike;
        Customer nick;
        Customer paul;
        Customer richard;
        Customer ryan;
        Customer sasha;
        Customer steven;
        Customer yolanda;
        
       public List<Customer> customers = new List<Customer>();

        public int weatherAdjust;

        // Constructor

        public Day(Player player)
        {
            this.player = player;
            this.aaron = new Customer("A-a-ron", 14, 15, 15, 12, 15, 5);
            this.alex = new Customer("Alex", 21, 16, 14, 15, 12, 4);
            this.david = new Customer("David", 32, 17, 14, 12, 14, 6);
            this.leah = new Customer("Leah", 15, 17, 5, 12, 15, 4);
            this.lisa = new Customer("Lisa", 28, 14, 15, 12, 17, 5);
            this.madonna = new Customer("Madonna", 55, 14, 16, 12, 14, 3);
            this.mark = new Customer("Mark", 24, 16, 14, 12, 14, 5);
            this.mike = new Customer("Mike", 33, 14, 15, 12, 17, 4);
            this.nick = new Customer("Nick", 41, 16, 16, 12, 16, 5);
            this.paul = new Customer("Paul", 45, 15, 14, 12, 14, 5);
            this.richard = new Customer("Richard", 25, 13, 17, 12, 17, 6);
            this.ryan = new Customer("Ryan", 70, 13, 16, 12, 16, 8);
            this.sasha = new Customer("Sashe", 37, 16, 13, 12, 15, 4);
            this.steven = new Customer("Steven", 43, 17, 15, 12, 15, 4);
            this.yolanda = new Customer("Yolanda", 53, 15, 15, 12, 15, 5);
            customers.Add(aaron);
            customers.Add(alex);
            customers.Add(david);
            customers.Add(leah);
            customers.Add(lisa);
            customers.Add(madonna);
            customers.Add(mark);
            customers.Add(mike);
            customers.Add(nick);
            customers.Add(paul);
            customers.Add(richard);
            customers.Add(ryan);
            customers.Add(sasha);
            customers.Add(steven);
            customers.Add(yolanda);
        }


        // member methods
        public void GoToLemonadeStand()
        {
            foreach (Customer customer in customers)
            {
               
                Random goToRandom = new Random();
                int arrival = goToRandom.Next(1, 21);
                
                if (arrival <= customer.chanceToGoToStand)
                {
                    Console.WriteLine(customer.name + " arrived at the Lemonade Stand.");
                }
                else
                {
                    Console.WriteLine(customer.name + " did not go to the stand today.");
                    customers.Remove(customer);
                }
                
            }
        }
        public void BuyLemonade()
        {
            foreach(Customer customer in customers)
            {
                Random randomBasedOnPrice = new Random();
                int priceBuy = randomBasedOnPrice.Next(1, 21);
                Random randomBasedOnSweetness = new Random();
                int sweetBuy = randomBasedOnSweetness.Next(1, 21);
                Random randomBasedOnColdness = new Random();
                int coldBuy = randomBasedOnColdness.Next(1, 21);
                if (priceBuy <= customer.chanceToBuyprice)
                {
                    Console.WriteLine(customer.name + " thinks the price is fair.");
                    if (sweetBuy <= customer.chanceToBuySweetLevel)
                    {
                        Console.WriteLine(customer.name + " thinks the recipe is good.");
                        if (coldBuy <= customer.chanceToBuyColdLevel)
                        {
                            Console.WriteLine(customer.name + " thinks the temperature of the lemonade is good.");
                            player.wallet.Money += player.recipe.pricePerCup;
                            player.wallet.NewBalance();
                            player.pitcher.cupsPerPitcher--;
                            if(player.pitcher.cupsPerPitcher == 0)
                            {
                                player.pitcher.pitchers.RemoveAt(0);
                                player.pitcher.cupsPerPitcher = 15;
                            }
                            BuyAgain();
                        }
                        else
                        {
                            Console.WriteLine(customer.name + " thinks the temperature of the lemonade is bad.");
                            customers.Remove(customer);
                        }
                    }
                    else
                    {
                        Console.WriteLine(customer.name + " thinks the recipe is bad.");
                    }
                }
                else
                {
                    Console.WriteLine(customer.name + " thinks the price is unfair.");
                }

            }
        }
        
        public void BuyAgain()
        {
            foreach (Customer customer in customers)
            { 
            Random buyAgain = new Random();
            int again = buyAgain.Next(1, 11);
            if (again <= customer.chanceToBuyAgain)
            {
                BuyLemonade();
            }
            else
            {
                Console.WriteLine(customer.name + " is satisfied.");
            }
        }
}
        public void CheckActualWeather()
        {
           
            ActualDayWeather();

            foreach (Customer customer in customers)
            {
                if (condition == "Sunny")
                {
                    customer.chanceToGoToStand += 2;
                    customer.chanceToBuyColdLevel -= 3;

                }
                else if (condition == "Rainy")
                {
                    customer.chanceToGoToStand -= 3;
                    customer.chanceToBuyColdLevel += 5;
                }
                else if (condition == "Thunder Storm")
                {
                    customer.chanceToGoToStand -= 10;
                    customer.chanceToBuyColdLevel += 10;
                }
            }
        }

        public void MasterCustomerBuyLemonade()
        {
            GoToLemonadeStand();
            while (customers.Count > 0 || player.inventory.cup.numInInventory > 0 || player.pitcher.pitchers.Count > 0)
            {
                BuyLemonade();
            }
            dayCounter--;
            player.pitcher.pitchers.Clear();
        }

    }
}
