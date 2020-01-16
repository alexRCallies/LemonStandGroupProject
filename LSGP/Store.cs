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
       public int i;
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
            foreach(Items item in storeStock)
            {
                Console.WriteLine($"Name: {item.name + " Price: " + item.price}");
            }
            for (i = 1; i < storeStock.Count; i++) ;
           
        }
        public void BuyItems()
        {
            PrintStoreStock();
            Console.WriteLine("Would you like to buy anything?");
            player.input = Console.ReadLine();
            if (player.input == storeStock[i].name)
            {
                Console.WriteLine("How many would you like to buy");
                try
                {
                    player.howManyToBuy = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please select a number you wish to buy");
                }
                Console.WriteLine("You want to buy "+ player.howManyToBuy+" "+ storeStock[i].name + " Yes/No");
                player.input = Console.ReadLine();
                if(player.input == "Yes")
                {
                    finalSale = player.howManyToBuy * storeStock[i].price;
                    player.wallet.money -= finalSale;
                }
                else
                {
                    BuyItems();
                }


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
