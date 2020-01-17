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
