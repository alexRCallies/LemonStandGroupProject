using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSGP
{
   
    class Game

    {
        public double weeklyProfit;
        public int dayCounter;
        Player player;
        Store store;
        Day day;
        public Game()
        {
            this.player = new Player();
            this.store = new Store(player);
            dayCounter = 7;
        }
        public void RunGame() //Master Method
        {
            User_Interface.Instructions();
            FindPlayerName();
            BeginDay();
        }
        public string FindPlayerName()
        {
            Console.WriteLine("What is your name?");
            player.name = Console.ReadLine();
            Console.Clear();
            return player.name;
        }
       
        public void BeginDay()
        {
            Console.Clear();
            day = new Day(player);
            Console.WriteLine("\nYou have " + dayCounter + " days left.");
            store = new Store(player);
            day.weather.MasterForecast();
            store.BuyItems();
            player.inventory.ShowCurrentInventory();
            player.recipe.MakeAPitcherOFLemonade();
            day.weather.ActualDayWeather();
            day.MasterCustomerBuyLemonade();
            
            if(dayCounter > 0)
            {
                weeklyProfit += day.dailyProfit;
                dayCounter--;
                BeginDay();
                
            }
            else
            {
                Console.WriteLine("\nYou ended the week with:");
                player.wallet.NewBalance();
                Console.WriteLine("\nTotal profit: $"+weeklyProfit);
                Console.ReadLine();

            }

        }
       
    }
}
