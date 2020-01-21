using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSGP
{
   public class Recipe
    {
       
        Inventory inventory;
        public int addLemons;
        public int addSugar;
        public int addIce;
        public int maxAmountOFSugarOrLemons = 5;
        public int minimumAmountOfLemons = 1;
        public int minimumAmountOfSugar = 1;
        int iceInLemonade;
        int lemonsInLemonade;
        int sugarInLemonade;
        int howManyPitchers;
        public double pricePerCup;

        
      

        public Recipe(Inventory inventory)
        {
            this.inventory = inventory;
          
            
        }
        public void AddLemonsToLemonade()
        {
            
            Console.WriteLine("How many lemons would you like to add");
            try
            {
                addLemons = int.Parse(Console.ReadLine());
            }
            catch(FormatException)
            {
                Console.WriteLine("Please choose a number not a letter");
            }
            if(inventory.lemons[0].numInInventory >= addLemons)
            {
                if(addLemons >= minimumAmountOfLemons)
                {
                    if (addLemons <= maxAmountOFSugarOrLemons)
                    {  
                            inventory.pitcher.PitcherSize -= addLemons;
                            lemonsInLemonade = addLemons;  
                    }
                    else
                    {
                        Console.WriteLine("\nThat is too many lemons for the pitcher.");
                        AddLemonsToLemonade();
                    }
                }
                else
                {
                    Console.WriteLine("\nYou must have at least 1.");
                    AddLemonsToLemonade();
                }
            }
            else
            {
                Console.WriteLine("\nYou don't have enough Lemons");
                
                
            }
        }
        public void AddSugarToLemonade()
        {
            Console.WriteLine("How much sugar in the lemonade");
            
            try
            {
                addSugar = int.Parse(Console.ReadLine());
            }
            catch(FormatException)
            {
                Console.WriteLine("Enter a number");
            }
            if(inventory.sugarCubes[0].numInInventory >= addSugar)
            {
                if(addSugar >= minimumAmountOfSugar)
                {
                    if (addSugar <= maxAmountOFSugarOrLemons)
                    {
                        if (addSugar == inventory.pitcher.PitcherSize)
                        {
                            sugarInLemonade = addSugar;

                        }
                        else
                        {
                            Console.WriteLine("You need add " + inventory.pitcher.PitcherSize + " more sugars.");
                            AddSugarToLemonade();
                        }
                    }
                }
                else
                {
                    Console.WriteLine("\nMust have at least " + inventory.pitcher.PitcherSize);
                    AddSugarToLemonade();
                }
            }
        }
        public void AddIceToLemonade()
        {
            Console.WriteLine("How much ice would you like to add to the pitcher?");
            
            try
            {
                addIce = int.Parse(Console.ReadLine());
            }
            catch(FormatException)
            {
                Console.WriteLine("Enter a number");
            }
                
                iceInLemonade = addIce;

        }
        public void MakeMultiplePitchers()
        {
            Console.WriteLine("How Many Pitchers Do You Want To Make?");
            try
            {
                howManyPitchers = int.Parse(Console.ReadLine());
            }
            catch(FormatException)
            {
                Console.WriteLine("Please Type A Number");
            }
            if(lemonsInLemonade*howManyPitchers <= inventory.lemons[0].numInInventory)
            {
                if(sugarInLemonade*howManyPitchers <= inventory.sugarCubes[0].numInInventory)
                {
                    if(iceInLemonade*howManyPitchers <= inventory.iceCubes[0].numInInventory)
                    {

                        inventory.iceCubes[0].numInInventory -= addIce*howManyPitchers;
                        inventory.sugarCubes[0].numInInventory -= addSugar*howManyPitchers;
                        inventory.lemons[0].numInInventory -= addLemons*howManyPitchers;
                    }
                    else
                    {
                        Console.WriteLine("\nInsufficient Ice: Lets start the recipe over.");
                        MakeAPitcherOFLemonade();
                    }
                }
                else
                {
                    Console.WriteLine("\nInsufficient Sugar: Lets start the recipe over.");
                    MakeAPitcherOFLemonade();
                }
            }
            else
            {
                Console.WriteLine("\nInsufficient Lemons: Lets start the recipe over.");
                MakeAPitcherOFLemonade();
            }
        }
        public void MakeAPitcherOFLemonade()
        {
            Console.Clear();
            Console.WriteLine("\nLet make some lemonade :-)");
            AddLemonsToLemonade();
            AddSugarToLemonade();
            AddIceToLemonade();
            inventory.pitcher.PitcherSize = 6;
            MakeMultiplePitchers();

            inventory.pitcher.sweetLevel = sugarInLemonade;
            inventory.pitcher.sourLevel = lemonsInLemonade;
            inventory.pitcher.coldLevel = iceInLemonade;

            inventory.pitchers[0].numOfPitchers += howManyPitchers;
           
            inventory.PrintPitchers();
           
            try
            {
                Console.WriteLine("How much should we sell each cup for?");
                pricePerCup = double.Parse(Console.ReadLine());
                Console.Clear();
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a number");
            }
        }
    }
}
