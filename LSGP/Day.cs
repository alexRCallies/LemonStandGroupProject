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
        Weather weather;
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
        public List<Customer> remainingCustomers = new List<Customer>();
       public List<Customer> customers = new List<Customer>();

        public int weatherAdjust;

        // Constructor

        public Day(Player player)
        {
            weather = new Weather();
            this.player = player;
            this.aaron = new Customer("A-a-ron", 14, 13, 15, 12, 15, 5);
            this.alex = new Customer("Alex", 21, 12, 14, 15, 12, 4);
            this.david = new Customer("David", 32, 15, 14, 12, 14, 6);
            this.leah = new Customer("Leah", 15, 15, 5, 12, 15, 4);
            this.lisa = new Customer("Lisa", 28, 10, 15, 12, 17, 5);
            this.madonna = new Customer("Madonna", 55, 12, 16, 12, 14, 3);
            this.mark = new Customer("Mark", 24, 16, 10, 12, 14, 5);
            this.mike = new Customer("Mike", 33, 14, 15, 12, 17, 4);
            this.nick = new Customer("Nick", 41, 10, 16, 12, 16, 5);
            this.paul = new Customer("Paul", 45, 12, 14, 12, 14, 5);
            this.richard = new Customer("Richard", 25, 13, 17, 12, 17, 6);
            this.ryan = new Customer("Ryan", 70, 13, 16, 12, 16, 8);
            this.sasha = new Customer("Sashe", 37, 13, 13, 12, 15, 4);
            this.steven = new Customer("Steven", 43, 15, 15, 12, 15, 4);
            this.yolanda = new Customer("Yolanda", 53, 10, 15, 12, 15, 5);
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
           for(int i = 0; i<customers.Count; i++)
           { 
                    //Random goToRNG = new Random();
                    int arrival = customers[i].rng1.Next(1, 21);


                    if (arrival <= customers[i].chanceToGoToStand)
                    {
                        Console.WriteLine(customers[i].name + " arrived at the Lemonade Stand");
                    remainingCustomers.Add(customers[i]);

                    }
                    else
                    {
                        Console.WriteLine(customers[i].name + " did not got to the stand today");
                        

                    }

                
           }
           
            foreach(Customer customer in remainingCustomers)
            {
                Console.WriteLine(customer.name);
            }
        }
        public void BuyLemonade()
        {
            customers.Clear();
            for (int i = 0; i<remainingCustomers.Count;i++)
                
                {
                //Random randomBasedOnPrice = new Random();
                int priceBuy = remainingCustomers[0].rng1.Next(1, 21);
               // Random randomBasedOnSweetness = new Random();
                int sweetBuy = remainingCustomers[0].rng1.Next(1, 21);
               // Random randomBasedOnColdness = new Random();
                int coldBuy = remainingCustomers[0].rng1.Next(1, 21);
                if (priceBuy <= remainingCustomers[i].chanceToBuyprice)
                {

                    Console.WriteLine(remainingCustomers[i].name + " thinks the price is fair");
                    if (sweetBuy <= remainingCustomers[i].chanceToBuySweetLevel)
                    {
                        Console.WriteLine(remainingCustomers[i].name + " thinks the recipe is good");
                        if (coldBuy <= remainingCustomers[i].chanceToBuyColdLevel)
                        {
                            Console.WriteLine(remainingCustomers[i].name + " thinks the tempature of the lemonade is good");
                            player.wallet.Money += player.recipe.pricePerCup;
                            player.wallet.NewBalance();
                            player.inventory.pitchers[0].cupsPerPitcher--;
                            player.inventory.cups[0].numInInventory--;
                            customers.Add(remainingCustomers[i]);
                            if (player.inventory.pitchers[0].cupsPerPitcher == 0)
                            {
                                player.inventory.pitchers.RemoveAt(0);
                                player.inventory.pitchers[0].cupsPerPitcher = 15;
                                if (player.inventory.pitchers.Count == 0)
                                {
                                    break;
                                }
                            }
                            if(player.inventory.cups[0].numInInventory == 0)
                            {
                                break;
                            }

                        }
                        else
                        {
                            Console.WriteLine(remainingCustomers[i].name + " thinks the tempature of the lemonade is bad");





                        }
                    }
                    else
                    {

                        Console.WriteLine(remainingCustomers[i].name + " thinks the recipe is bad");


                    }
                }
                else
                {

                    Console.WriteLine(remainingCustomers[i].name + " thinks the price is unfair");
                }


            }
            
            BuyAgain();
        }
        
        public void BuyAgain()
        {
            remainingCustomers.Clear();
            for (int i = 0; i<customers.Count;i++)
            { 
            Random buyAgain = new Random();
            int again = customers[0].rng1.Next(1, 11);
            if (again <= customers[i].chanceToBuyAgain)
            {
                    remainingCustomers.Add(customers[i]);
                
            }
            else
            {

                Console.WriteLine(customers[i].name + " is satisfied");

            }
                
        }
}
        public void CheckActualWeather()
        {
           

            ActualDayWeather();


            for(int i =0; i<customers.Count; i++)
            {
                if (condition == weather.weatherConditions[3])
                {
                    customers[i].chanceToGoToStand += 2;
                    customers[i].chanceToBuyColdLevel -= 3;

                }
                else if (condition == weather.weatherConditions[1])
                {
                    customers[i].chanceToGoToStand -= 3;
                    customers[i].chanceToBuyColdLevel += 5;
                }
                else if (condition == weather.weatherConditions[2])
                {
                    customers[i].chanceToGoToStand -= 10;
                    customers[i].chanceToBuyColdLevel += 10;
                }
            }
        }

        public void MasterCustomerBuyLemonade()
        {
            
            GoToLemonadeStand();
            if(player.inventory.pitchers[0].numOfPitchers > 0)
            { 
                if(player.inventory.cup.numInInventory > 0)
                {
                    if(customers.Count > 0)
                    {
                        BuyLemonade();
                    }
                    else
                    {
                        Console.WriteLine("No one wants to buy lemonade");
                    }
                }
                else
                {
                    Console.WriteLine("You have no cups");
                }
            }
            else
            {
                Console.WriteLine("You have no more lemonade");
            }
                
            
            dayCounter--;
            player.inventory.pitchers[0].numOfPitchers = 0;
        }

    }
}
