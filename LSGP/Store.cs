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
        Inventory inventory = new Inventory();
        
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
            //for (i = 1; i < storeStock.Count; i++) ;

        }
        public void BuyLemons(List<Lemon>lemons)
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
                lemons[0].numInInventory += player.howManyToBuy;
                inventory.ShowCurrentInventory();
                player.wallet.NewBalance();
            }
        }
        public void BuySugarCubes(List<Sugar_Cube> sugarCubes)
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
                sugarCubes[0].numInInventory += player.howManyToBuy;
                inventory.ShowCurrentInventory();
                player.wallet.NewBalance();
            }
        }
        public void BuyIceCubes(List<Ice_Cube> iceCubes)
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
                iceCubes[0].numInInventory += player.howManyToBuy;
                inventory.ShowCurrentInventory();
                player.wallet.NewBalance();
            }
        }
        public void BuyCups(List<Cup> cups)
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
            finalSale = cups[0].price * player.howManyToBuy;
            Console.WriteLine("The cost will be: " + finalSale);
            if (player.wallet.money >= finalSale)
            {
                player.wallet.money -= finalSale;
                cups[0].numInInventory += (player.howManyToBuy * cups[0].numOfCupsInAPack);
                inventory.ShowCurrentInventory();
                player.wallet.NewBalance();
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
                BuyLemons(inventory.lemons);
            }
           else if(player.input == storeStock[1].name)
            {
                BuySugarCubes(inventory.sugarCubes);
            }
            else if(player.input == storeStock[2].name)
            {
                BuyIceCubes(inventory.iceCubes);
            }
            else if(player.input == storeStock[3].name)
            {
                BuyCups(inventory.cups);
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

