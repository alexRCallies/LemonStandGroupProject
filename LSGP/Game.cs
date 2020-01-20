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
            Console.WriteLine("Instructions");
            Console.WriteLine("\n Your goal is to make as much money as you can in \n 7, 14, or 30 days by " +
                "selling lemonade at your lemonade \n  stand.");
            Console.WriteLine("\n\n Buy cups, lemons, sugar, and ice cubes, then set\n your recipe based on " +
                "the weather and conditions. Start\n with the basic recipe, but try to vary the recipe \n" +
                " and see if you can do better. Lastly, set your price \n and sell your lemonade at the stand." +
                " Try changing \n up the price based on the weather conditions as well.");
            Console.WriteLine("\n\n At the end of the game, you'll see how much money\n you made. Write it down and " +
                "play again\n to try and beat your score!");
            Console.WriteLine("\nReady to play?  Yes or No" );
            string confirmation = Console.ReadLine();
            if ((confirmation == "no")||(confirmation == "No")||(confirmation == "NO")||(confirmation == "n")
                ||(confirmation == "N")||(confirmation=="nope")||(confirmation=="Nope")||(confirmation == "NOPE")||
                (confirmation == "NOpe")||(confirmation == "NOPe")||(confirmation == "nOpe"))
            {
                Console.WriteLine("Alright, lets go over the instructions again:");
                RunGame();
            }
            else
            {
                Console.WriteLine("Great! Lets get started!");
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
            Console.WriteLine("What do you want to do Store/Inventory/Recipe");
            player.input = Console.ReadLine();
            if (player.input == "Store")
            {
                store = new Store(player);
                store.BuyItems();
                PlayerChoice();
            }
            else if (player.input == "Inventory")
            {
                player.inventory.ShowCurrentInventory();
                PlayerChoice();
            }
            else if (player.input == "Recipe")
            {
                
                player.recipe.MakeAPitcherOFLemonade();
                PlayerChoice();
            }
        }
    }
}
