using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSGP
{
    public class Day
    {
        // member variables
        public Weather weather = new Weather();
        
        public double dailyProfit;
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
            this.player = player;
            this.aaron = new Customer("A-a-ron", 14, 65, 50, 60, 75, 50);
            this.alex = new Customer("Alex", 21, 60, 60, 75, 60, 40);
            this.david = new Customer("David", 32, 50, 65, 60, 70, 60);
            this.leah = new Customer("Leah", 15, 55, 35, 60, 75, 40);
            this.lisa = new Customer("Lisa", 28, 45, 75, 60, 85, 50);
            this.madonna = new Customer("Madonna", 55, 60, 70, 60, 65, 30);
            this.mark = new Customer("Mark", 24, 45, 50, 60, 65, 50);
            this.mike = new Customer("Mike", 33, 65, 65, 60, 60, 40);
            this.nick = new Customer("Nick", 41, 50, 55, 60, 50, 50);
            this.paul = new Customer("Paul", 45, 60, 65, 60, 50, 50);
            this.richard = new Customer("Richard", 25, 65, 80, 60, 65, 60);
            this.ryan = new Customer("Ryan", 70, 55, 50, 60, 45, 80);
            this.sasha = new Customer("Sashe", 37, 45, 45, 60, 45, 40);
            this.steven = new Customer("Steven", 43, 70, 70, 60, 50, 40);
            this.yolanda = new Customer("Yolanda", 53, 50, 75, 60, 60, 50);
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
        }
        public void BuyLemonade()
        {
            customers.Clear();
            for (int i = 0; i<remainingCustomers.Count;i++)
                
                {
                
                int priceBuy = remainingCustomers[0].rng1.Next(1, 101);
              
                int sweetBuy = remainingCustomers[0].rng1.Next(1, 101);
             
                int coldBuy = remainingCustomers[0].rng1.Next(1, 101);
                if (priceBuy <= remainingCustomers[i].chanceToBuyprice)
                {

                    Console.WriteLine(remainingCustomers[i].name + " thinks the price is fair");
                    if (sweetBuy <= remainingCustomers[i].chanceToBuySweetLevel)
                    {
                        Console.WriteLine("thinks the recipe is good");
                        if (coldBuy <= remainingCustomers[i].chanceToBuyColdLevel)
                        {
                            Console.WriteLine(" thinks the tempature of the lemonade is good");
                            player.wallet.Money += player.recipe.pricePerCup;
                            dailyProfit += player.recipe.pricePerCup;
                            player.wallet.NewBalance();
                            player.inventory.pitchers[0].cupsPerPitcher--;
                            player.inventory.cups[0].numInInventory--;
                            customers.Add(remainingCustomers[i]);
                            if (player.inventory.pitchers[0].cupsPerPitcher == 0)
                            {
                                player.inventory.pitchers[0].numOfPitchers--;
                                player.inventory.pitchers[0].cupsPerPitcher = 15;
                                
                            }
                            if(player.inventory.cups[0].numInInventory == 0)
                            {
                                break;
                            }

                        }
                        else
                        {
                            Console.WriteLine("but "+remainingCustomers[i].name + " thinks the tempature of the lemonade is bad");
                        }
                    }
                    else
                    {

                        Console.WriteLine("but " + remainingCustomers[i].name + " thinks the recipe is bad");
                    }
                }
                else
                {
                    Console.WriteLine("but " + remainingCustomers[i].name + " thinks the price is unfair");
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
            int again = customers[0].rng1.Next(1, 101);
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
           

            weather.ActualDayWeather();


            for(int i =0; i<customers.Count; i++)
            {

                if (weather.condition == weather.weatherConditions[3])

                {
                    customers[i].chanceToGoToStand += 20;
                   

                }

                else if (weather.condition == weather.weatherConditions[1])

                {
                    customers[i].chanceToGoToStand -= 15;
                    
                }

                else if (weather.condition == weather.weatherConditions[2])

                {
                    customers[i].chanceToGoToStand -= 25;
                    
                }
            }
        }
        public void CheckOtherCondition()
        {
            for(int i = 0; i < remainingCustomers.Count; i++)
            {
                if (player.recipe.pricePerCup >= 5)
                {
                    remainingCustomers[i].chanceToBuyprice -= 15;
                }
                else if (player.recipe.pricePerCup == 2)
                {
                    remainingCustomers[i].chanceToBuyprice += 10;
                }
                else if (player.recipe.pricePerCup == 1)
                {
                    remainingCustomers[i].chanceToBuyprice += 25;
                }
                else if (player.recipe.pricePerCup == 4)
                {
                    remainingCustomers[i].chanceToBuyprice -= 10;
                }
                if(player.inventory.pitchers[0].sweetLevel <= 5)
                {
                    remainingCustomers[i].chanceToBuySweetLevel += 100;
                }
                else if(player.inventory.pitchers[0].sweetLevel == 4)
                {
                    remainingCustomers[i].chanceToBuySweetLevel += 40;
                }
                else if(player.inventory.pitchers[0].sweetLevel == 2)
                {
                    remainingCustomers[i].chanceToBuySweetLevel -= 15;
                }
                else if(player.inventory.pitchers[0].sweetLevel == 1)
                {
                    remainingCustomers[i].chanceToBuySweetLevel -= 25;
                }
                if (weather.temperature <= 85)
                {
                    remainingCustomers[i].chanceToBuyColdLevel -= 20;
                }
                else if (weather.temperature >= 45)
                {
                    remainingCustomers[i].chanceToBuyColdLevel += 35;

                }
                if(player.inventory.pitchers[0].coldLevel == 1)
                {
                    remainingCustomers[i].chanceToBuyColdLevel += 5;
                }
                else if(player.inventory.pitchers[0].coldLevel == 2)
                {
                    remainingCustomers[i].chanceToBuyColdLevel += 10;
                }
                else if(player.inventory.pitchers[0].coldLevel == 3)
                {
                    remainingCustomers[i].chanceToBuyColdLevel += 15;
                }
                else if(player.inventory.pitchers[0].coldLevel == 4)
                {
                    remainingCustomers[0].chanceToBuyColdLevel += 20;
                }
                else if(player.inventory.pitchers[0].coldLevel <= 5)
                {
                    remainingCustomers[0].chanceToBuyColdLevel += 25;
                }
            }
        }
        public void MasterCustomerBuyLemonade()
        {
            
            GoToLemonadeStand();
            if(player.inventory.pitchers[0].numOfPitchers > 0)
            { 

                if(player.inventory.cups[0].numInInventory > 0)

                {
                    if(customers.Count > 0)
                    {
                        CheckOtherCondition();
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

            Console.WriteLine("You made: $" +dailyProfit);
            Console.WriteLine("The Day is Over");
           
            player.inventory.pitchers[0].numOfPitchers = 0;
        }

    }
}
