using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSGP
{
    class Recipe
    {
        Pitcher pitcher = new Pitcher();
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
                            pitcher.PitcherSize -= addLemons;
                            lemonsInLemonade = addLemons;
                        inventory.lemons[0].numInInventory -= addLemons;
                        
                    }
                }
                else
                {
                    Console.WriteLine("Must have at least 1");
                    AddLemonsToLemonade();
                }
            }
            else
            {
                Console.WriteLine("Insufficient Lemons");
                
                
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
                        if (addSugar == pitcher.PitcherSize)
                        {
                            sugarInLemonade = addSugar;
                                inventory.sugarCubes[0].numInInventory -= addSugar;
                        }
                        else
                        {
                            Console.WriteLine("You need " +pitcher.PitcherSize + " more sugars.");
                            AddSugarToLemonade();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Exceeding pitcher limit");
                        AddSugarToLemonade();
                    }
                }
                else
                {
                    Console.WriteLine("Must have at least 1");
                    AddSugarToLemonade();
                }
            }
            else
            {
                Console.WriteLine("Insufficient Sugar");
                
            }
        }
        public void AddIceToLemonade()
        {
            Console.WriteLine("How much ice in the lemonade");
            
            try
            {
                addIce = int.Parse(Console.ReadLine());
            }
            catch(FormatException)
            {
                Console.WriteLine("Enter a number");
            }
            if(inventory.iceCubes[0].numInInventory >= addIce)
            {
                
                iceInLemonade = addIce;
                inventory.iceCubes[0].numInInventory -= addIce;
            }
            else
            {
                Console.WriteLine("Insufficient Ice");
                
            }
        }
        public void MakeAPitcherOFLemonade()
        {
            AddLemonsToLemonade();
            AddSugarToLemonade();
            AddIceToLemonade();
            pitcher.PitcherSize = 6;
            pitcher.pitchers.Add(pitcher);
            pitcher.pitchers[pitcher.i].sweetLevel = sugarInLemonade;
            pitcher.pitchers[pitcher.i].sourLevel = lemonsInLemonade;
            pitcher.pitchers[pitcher.i].coldLevel = iceInLemonade;
            
            pitcher.PrintPitchers();
           
        }
    }
}
