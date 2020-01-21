using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSGP
{
    class Store
    {
        Lemon lemon = new Lemon();
        Sugar_Cube sugarCube = new Sugar_Cube();
        Ice_Cube iceCube = new Ice_Cube();
        Cup cups = new Cup();
        List<Items> storeStock = new List<Items>();
        public int howManyToBuy;
        Player player;
        
        
        public double finalSale;
        public Store(Player player)
        {
            this.player = player;
            storeStock.Add(lemon);
            storeStock.Add(sugarCube);
            storeStock.Add(iceCube);
            storeStock.Add(cups);
           
        }
        public void PrintStoreStock()
        {
            Console.WriteLine("\n          Welcome to the store!");
            foreach (Items item in storeStock)
            {
                Console.WriteLine($"Name: {item.name + " Price: $" + item.price}");
            }
        }
        public void BuyLemons()//Single responsibility principle, used solely for buying lemons and no other ingredient. - Alex
        {
            Console.WriteLine("How many would you like to buy?");
            try
            {
                howManyToBuy = int.Parse(Console.ReadLine());
            }
            catch(FormatException)
            {
                Console.WriteLine("Enter A Number");
            }
            finalSale = lemon.price * howManyToBuy;
            Console.WriteLine("The cost will be: $"+ finalSale);
            if(player.wallet.Money >= finalSale)
            {
                player.wallet.Money -= finalSale;
                player.inventory.lemons[0].numInInventory += howManyToBuy;
                //player.inventory.ShowCurrentInventory();
                player.wallet.NewBalance();
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("\nNot enough funds :(\n");
                
            }
        }
        public void BuySugarCubes()
        {
            Console.WriteLine("How many would you like to buy?");
            try
            {
                howManyToBuy = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Enter A Number");
            }
            finalSale = sugarCube.price * howManyToBuy;
            Console.WriteLine("The cost will be: $" + finalSale);
            if (player.wallet.Money >= finalSale)
            {
                player.wallet.Money -= finalSale;
                player.inventory.sugarCube.numInInventory += howManyToBuy;
                //player.inventory.ShowCurrentInventory();
                player.wallet.NewBalance();
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("\nNot enough funds :(\n");
                
            }
        }
        public void BuyIceCubes()
        {
            Console.WriteLine("How many would you like to buy?");
            try
            {
                howManyToBuy = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Enter A Number");
            }
            finalSale = iceCube.price * howManyToBuy;
            Console.WriteLine("The cost will be: $" + finalSale);
            if (player.wallet.Money >= finalSale)
            {
                player.wallet.Money -= finalSale;
                player.inventory.iceCube.numInInventory += howManyToBuy;
                //player.inventory.ShowCurrentInventory();
                player.wallet.NewBalance();
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("\nNot enough funds :(\n");
                
            }
        }
        public void BuyCups()
        {
            Console.WriteLine("How many would you like to buy?");
            try
            {
                howManyToBuy = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Enter A Number");
            }
            finalSale = cups.price * howManyToBuy;
            Console.WriteLine("The cost will be: $" + finalSale);
            if (player.wallet.Money >= finalSale)
            {
                player.wallet.Money -= finalSale;
                player.inventory.cup.numInInventory += (howManyToBuy * cups.numOfCupsInAPack);
                //player.inventory.ShowCurrentInventory();
                player.wallet.NewBalance();
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("\nNot enough funds :(\n");
                
            }
        }
        public void BuyItems()//Open/Closed principle, methods can be extended for further gameplay without any drastic repercussions. -alex
        {
            Console.WriteLine("\n\nLets head to the store to stock up for the day!");
            PrintStoreStock();
            player.inventory.ShowCurrentInventory();
            player.wallet.NewBalance();
            Console.WriteLine("");
            Console.WriteLine("What would you like to buy? If you are done shopping enter 'Nothing'. \n");
            player.input = Console.ReadLine();
            if ((player.input == storeStock[0].name) || (player.input == "LEMONS") || (player.input == "lemons")
                || (player.input == "lemon") || (player.input == "LEMON") || (player.input == "Lemons"))
            {
                BuyLemons();
                BuyItems();
            }
            else if ((player.input == storeStock[2].name) || (player.input == "Sugar") || (player.input == "SUGAR")
                || (player.input == "SUGAR CUBE") || (player.input == "SugarCube") || (player.input == "sugar cube") || (player.input == "sugar"))
            {
                BuySugarCubes();
                BuyItems();
            }
            else if ((player.input == storeStock[2].name) || (player.input == "Ice") || (player.input == "ICE")
                || (player.input == "ICE CUBE") || (player.input == "IceCube") || (player.input == "ice") || (player.input == "Ice Cube") || (player.input == "ice cube"))
            {
                BuyIceCubes();
                BuyItems();
            }
            else if ((player.input == storeStock[3].name) || (player.input == "CUPS") || (player.input == "CUP")
                || (player.input == "cup") || (player.input == "CUps") || (player.input == "cups") || (player.input == "Cups") || (player.input == "Cup"))
            {
                BuyCups();
                BuyItems();
            }
            else if ((player.input == "No") || (player.input == "Nothing") || (player.input == "nada") || (player.input == "Nada")
                || (player.input == "nothing"))
            {
                Console.WriteLine("Thanks for visiting, you have left the store.\n");
            }
            else
            {
                Console.WriteLine("That is a not a valid entry, please try again.\n");
                BuyItems();
            }
          
        }
    }
}

