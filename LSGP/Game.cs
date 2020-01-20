using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSGP
{
    class Game
    {
        Player player;
        Store store;

        

        Weather weather = new Weather();


        public Game()
        {
            this.player = new Player();
            this.store = new Store(player);
            
        }

        public void RunGame() //Master Method
        {
            Instructions();
            FindPlayerName();
            PlayerChoice();
            
            
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
        public void PlayerChoice()
        {
            Console.WriteLine("\nWhat do you want to do Store/Inventory/Recipe/Play?");
            player.input = Console.ReadLine();
            if ((player.input == "Store") || (player.input == "store") || (player.input == "sTore") || (player.input == "STORE")
                || (player.input == "stOre") || (player.input == "StoRe") || (player.input == "storE") || (player.input == "S"))
            {
                store = new Store(player);
                store.BuyItems();
                PlayerChoice();
            }
            else if ((player.input == "Inventory") || (player.input == "I") || (player.input == "Inven") || (player.input == "INVENTORY")
                || (player.input == "inventory") || (player.input == "Inventry") || (player.input == "Invent") || (player.input == "In"))
            {
                player.inventory.ShowCurrentInventory();
                PlayerChoice();
            }

            else if ((player.input == "Recipe") || (player.input == "R") || (player.input == "RECIPE") || (player.input == "recipe")
                || (player.input == "Recip") || (player.input == "REcipe") || (player.input == "reCipe") || (player.input == "Rec"))
            {
                player.recipe.MakeAPitcherOFLemonade();
                PlayerChoice();
            }
            else if ((player.input == "Play") || (player.input == "P") || (player.input == "PLAY") || (player.input == "P")
                || (player.input == "PLay") || (player.input == "play"))
            {
                // Play Game Method place holder
            }
            else
            {
                Console.WriteLine("That is not a valid entry, try again.");
                PlayerChoice();
            }
        }
        public void WeatherForecast()
        {
            weather.MasterForecast();
        }
        public void ActualDailyWeather()
        {
            weather.ActualDayWeather();
        }
    }
}
