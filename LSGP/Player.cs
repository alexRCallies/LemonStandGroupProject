using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSGP
{
    class Player
    {
        public string name;
        public Wallet wallet;
        public string input;
        public Inventory inventory;
        public Recipe recipe;
        

        public Player()
        {
            inventory = new Inventory();
            wallet = new Wallet();
            recipe = new Recipe(inventory) ;
        }
            
        //public string FindPlayerName()
        //{
        //    Console.WriteLine("What is your name?");
        //    name = Console.ReadLine();
        //    return name;
        //}
        //public void PlayerChoice()
        //{
        //    Console.WriteLine("What do you want to do Store/Inventory/Recipe");
        //    input = Console.ReadLine();
        //    if (input == "Store")
        //    {
        //        store = new Store();
        //        store.BuyItems();
        //    }
        //    else if (input == "Inventory") 
        //    {
        //        inventory.ShowCurrentInventory();
        //        PlayerChoice();
        //    } 
        //    else if(input == "Recipe")
        //    {
        //        recipe = new Recipe();
        //        recipe.MakeAPitcherOFLemonade();
        //        PlayerChoice();
        //    }
        //}
    }
}
