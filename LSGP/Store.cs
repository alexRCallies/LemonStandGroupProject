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
        Player player = new Player();
        
        
        public double finalSale;
        public Store()
        {
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
                player.howManyToBuy = int.Parse(Console.ReadLine());
            }
            catch(FormatException)
            {
                Console.WriteLine("Enter A Number");
            }
            finalSale = lemon.price * player.howManyToBuy;
            Console.WriteLine("The cost will be: "+ finalSale);
            if(player.wallet.money >= finalSale)
            {
                player.wallet.money -= finalSale;
                player.inventory.lemons[0].numInInventory += player.howManyToBuy;
                player.inventory.ShowCurrentInventory();
                player.wallet.NewBalance();
            }
            else
            {
                Console.WriteLine("Not enough funds :(");
                player.PlayerChoice();
            }
        }
        public void BuySugarCubes()
        {
            Console.WriteLine("How many would you like to buy");
            try
            {
                player.howManyToBuy = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Enter A Number");
            }
            finalSale = sugarCube.price * player.howManyToBuy;
            Console.WriteLine("The cost will be: " + finalSale);
            if (player.wallet.money >= finalSale)
            {
                player.wallet.money -= finalSale;
                player.inventory.sugarCubes[0].numInInventory += player.howManyToBuy;
                player.inventory.ShowCurrentInventory();
                player.wallet.NewBalance();
            }
            else
            {
                Console.WriteLine("Not enough funds :(");
                player.PlayerChoice();
            }
        }
        public void BuyIceCubes()
        {
            Console.WriteLine("How many would you like to buy");
            try
            {
                player.howManyToBuy = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Enter A Number");
            }
            finalSale = iceCube.price * player.howManyToBuy;
            Console.WriteLine("The cost will be: " + finalSale);
            if (player.wallet.money >= finalSale)
            {
                player.wallet.money -= finalSale;
                player.inventory.iceCubes[0].numInInventory += player.howManyToBuy;
                player.inventory.ShowCurrentInventory();
                player.wallet.NewBalance();
            }
            else
            {
                Console.WriteLine("Not enough funds :(");
                player.PlayerChoice();
            }
        }
        public void BuyCups()
        {
            Console.WriteLine("How many would you like to buy");
            try
            {
                player.howManyToBuy = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Enter A Number");
            }
            finalSale = player.inventory.cups[0].price * player.howManyToBuy;
            Console.WriteLine("The cost will be: " + finalSale);
            if (player.wallet.money >= finalSale)
            {
                player.wallet.money -= finalSale;
                player.inventory.cups[0].numInInventory += (player.howManyToBuy * player.inventory.cups[0].numOfCupsInAPack);
                player.inventory.ShowCurrentInventory();
                player.wallet.NewBalance();
            }
            else
            {
                Console.WriteLine("Not enough funds :(");
                player.PlayerChoice();
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
                player.PlayerChoice();
            }
            else
            {
                BuyItems();
            }
        }
    }
}

