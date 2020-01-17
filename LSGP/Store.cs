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
            foreach (Items item in storeStock)
            {
                Console.WriteLine($"Name: {item.name + " Price: " + item.price}");
            }
           

        }
        public void BuyLemons()
        {
            Console.WriteLine("How many would you like to buy");
            try
            {
                howManyToBuy = int.Parse(Console.ReadLine());
            }
            catch(FormatException)
            {
                Console.WriteLine("Enter A Number");
            }
            finalSale = lemon.price * howManyToBuy;
            Console.WriteLine("The cost will be: "+ finalSale);
            if(player.wallet.Money >= finalSale)
            {
                player.wallet.Money -= finalSale;
                player.inventory.lemons[0].numInInventory += howManyToBuy;
                player.inventory.ShowCurrentInventory();
                player.wallet.NewBalance();
            }
            else
            {
                Console.WriteLine("Not enough funds :(");
                
            }
        }
        public void BuySugarCubes()
        {
            Console.WriteLine("How many would you like to buy");
            try
            {
                howManyToBuy = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Enter A Number");
            }
            finalSale = sugarCube.price * howManyToBuy;
            Console.WriteLine("The cost will be: " + finalSale);
            if (player.wallet.Money >= finalSale)
            {
                player.wallet.Money -= finalSale;
                player.inventory.sugarCube.numInInventory += howManyToBuy;
                player.inventory.ShowCurrentInventory();
                player.wallet.NewBalance();
            }
            else
            {
                Console.WriteLine("Not enough funds :(");
                
            }
        }
        public void BuyIceCubes()
        {
            Console.WriteLine("How many would you like to buy");
            try
            {
                howManyToBuy = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Enter A Number");
            }
            finalSale = iceCube.price * howManyToBuy;
            Console.WriteLine("The cost will be: " + finalSale);
            if (player.wallet.Money >= finalSale)
            {
                player.wallet.Money -= finalSale;
                player.inventory.iceCube.numInInventory += howManyToBuy;
                player.inventory.ShowCurrentInventory();
                player.wallet.NewBalance();
            }
            else
            {
                Console.WriteLine("Not enough funds :(");
                
            }
        }
        public void BuyCups()
        {
            Console.WriteLine("How many would you like to buy");
            try
            {
                howManyToBuy = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Enter A Number");
            }
            finalSale = cups.price * howManyToBuy;
            Console.WriteLine("The cost will be: " + finalSale);
            if (player.wallet.Money >= finalSale)
            {
                player.wallet.Money -= finalSale;
                player.inventory.cup.numInInventory += (howManyToBuy * cups.numOfCupsInAPack);
                player.inventory.ShowCurrentInventory();
                player.wallet.NewBalance();
            }
            else
            {
                Console.WriteLine("Not enough funds :(");
                
            }
        }
        public void BuyItems()
        {
            PrintStoreStock();
            player.inventory.ShowCurrentInventory();
            player.wallet.NewBalance();
            Console.WriteLine("Would you like to buy anything?");
            player.input = Console.ReadLine();
            if(player.input == storeStock[0].name)
            {
                BuyLemons();
                BuyItems();
            }
           else if(player.input == storeStock[1].name)
            {
                BuySugarCubes();
                BuyItems();
            }
            else if(player.input == storeStock[2].name)
            {
                BuyIceCubes();
                BuyItems();
            }
            else if(player.input == storeStock[3].name)
            {
                BuyCups();
                BuyItems();
            }
            else if(player.input == "No")
            {
                Console.WriteLine("You have left the store");
            }
            else
            {
                BuyItems();
            }
        }
    }
}

