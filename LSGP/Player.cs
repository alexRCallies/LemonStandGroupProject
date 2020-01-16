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
        public int howManyToBuy;
        Store store;
       public Inventory inventory = new Inventory();
        

        public Player()
        {
            wallet = new Wallet();
        }
            
        public string FindPlayerName()
        {
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            return name;
        }
        public void PlayerChoice()
        {
            input = Console.ReadLine();
            if (input == "Store")
            {
                store = new Store();
                store.BuyItems();
            }
            else if (input == "Inventory") 
            {
                inventory.ShowCurrentInventory();
            }            
        }
    }
}
