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
       public void CheckPlayConditions()
        {
            int numOfLemonsAndSugar;
            numOfLemonsAndSugar = player.inventory.lemons[0].numInInventory + player.inventory.sugarCubes[0].numInInventory;
            if(numOfLemonsAndSugar > 6 && player.wallet.Money <= 0)
            {
                Console.WriteLine("You do not have enough money to buy the minimum amount of stock");
                User_Interface.End();
            }
        }
        public void CheckEndCondtions()
        {
            if(dayCounter == 0)
            {
                Console.WriteLine("\nYou ended the week with:");
                player.wallet.NewBalance();
                Console.WriteLine("\nTotal profit: $" + weeklyProfit);
                Console.ReadLine();
                User_Interface.End();
            }
            else
            {
                weeklyProfit += day.dailyProfit;
                dayCounter--;
                BeginDay();
            }
        }
       
        public void BeginDay()
        {
            Console.Clear();
            day = new Day(player);
            Console.WriteLine("\nHi there " + player.name + "! You have " + dayCounter + " days left to make as much money as you can.");
            store = new Store(player);
            day.weather.MasterForecast();
            store.BuyItems();
            player.inventory.ShowCurrentInventory();
            CheckPlayConditions();
            player.recipe.MakeAPitcherOFLemonade();
            day.weather.ActualDayWeather();
            day.MasterCustomerBuyLemonade();
            CheckEndCondtions();
        }
       
    }
}
