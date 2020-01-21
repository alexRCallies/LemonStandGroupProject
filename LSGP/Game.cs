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
            Instructions();
            FindPlayerName();

            BeginDay();
           
        }

        public void Instructions()
        {
            Console.WriteLine("          Welcome to Lemonade Stand!          ");
            Console.WriteLine("                  Instructions          ");
            Console.WriteLine("\n Your goal is to make as much money as you can in \n 7 days by " +
                "selling lemonade at your lemonade stand.");
            Console.WriteLine("\n\n Buy cups, lemons, sugar, and ice cubes, then set\n your recipe based on " +
                "the weather and conditions. Start\n with the basic recipe, but try to vary the recipe \n" +
                " and see if you can do better. Lastly, set your price \n and sell your lemonade at the stand." +
                " Try changing \n up the price based on the weather conditions as well.");
            Console.WriteLine("\n\n At the end of the game, you'll see how much money\n you made. Write it down and " +
                "play ain\n to try and beat your score!");
            Console.WriteLine("\nReady to play?  Yes or No" );
            string confirmation = Console.ReadLine();
            if ((confirmation == "no")||(confirmation == "No")||(confirmation == "NO")||(confirmation == "n")
                ||(confirmation == "N")||(confirmation=="nope")||(confirmation=="Nope")||(confirmation == "NOPE")||
                (confirmation == "NOpe")||(confirmation == "NOPe")||(confirmation == "nOpe"))
            {
                Console.WriteLine("Alright, lets go over the instructions again:");
                RunGame();
            }
            else if ((confirmation == "yes") || (confirmation == "Yes") || (confirmation == "YES") || (confirmation == "y")
                || (confirmation == "Y") || (confirmation == "yup") || (confirmation == "Yup") || (confirmation == "YUP") ||
                (confirmation == "YUp") || (confirmation == "yUp") || (confirmation == "yuP"))
            {
                Console.WriteLine("Great! Lets get started!\n");
            }
            else
            {
                Console.WriteLine("That is not a valid answer, Please tray again");
                InstructionRedo();
            }
        }
        public void InstructionRedo()
        {
            Console.WriteLine("\nReady to play?  Yes or No");
            string confirmation = Console.ReadLine();
            if ((confirmation == "no") || (confirmation == "No") || (confirmation == "NO") || (confirmation == "n")
                || (confirmation == "N") || (confirmation == "nope") || (confirmation == "Nope") || (confirmation == "NOPE") ||
                (confirmation == "NOpe") || (confirmation == "NOPe") || (confirmation == "nOpe"))
            {
                Console.WriteLine("Alright, lets go over the instructions again:");
                RunGame();
            }
            else if ((confirmation == "yes") || (confirmation == "Yes") || (confirmation == "YES") || (confirmation == "y")
                || (confirmation == "Y") || (confirmation == "yup") || (confirmation == "Yup") || (confirmation == "YUP") ||
                (confirmation == "YUp") || (confirmation == "yUp") || (confirmation == "yuP"))
            {
                Console.WriteLine("Great! Lets get started!\n");
            }
           
        }
        public string FindPlayerName()
        {
            Console.WriteLine("What is your name?");
            player.name = Console.ReadLine();
            return player.name;
        }
       
        public void BeginDay()
        {
           
            day = new Day(player);
            Console.WriteLine("You have " + dayCounter + " days left.");
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
                Console.WriteLine("You ended the week with:");
                player.wallet.NewBalance();
                Console.WriteLine("Total profit: $"+weeklyProfit);

            }

        }
       
    }
}
