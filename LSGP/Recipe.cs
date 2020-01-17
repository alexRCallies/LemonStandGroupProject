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
        
        public int addLemons;
        public int addSugar;
        public int addIce;
        public int maxAmountOFSugarOrLemons = 5;
        public int minimumAmountOfLemons = 1;
        public int minimumAmountOfSugar = 1;
        int iceInLemonade;
        int lemonsInLemonade;
        int sugarInLemonade;

        Player player = new Player();
        List<Pitcher> pitchers = new List<Pitcher>();
        

        public Recipe()
        {

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
            if(player.inventory.lemons[0].numInInventory >= addLemons)
            {
                if(addLemons >= minimumAmountOfLemons)
                {
                    if (addLemons <= maxAmountOFSugarOrLemons)
                    {  
                            pitcher.PitcherSize -= addLemons;
                            lemonsInLemonade = addLemons;
                        player.inventory.lemons[0].numInInventory -= addLemons;
                        
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
                player.PlayerChoice();
                
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
            if(player.inventory.sugarCubes[0].numInInventory >= addSugar)
            {
                if(addSugar >= minimumAmountOfSugar)
                {
                    if (addSugar <= maxAmountOFSugarOrLemons)
                    {
                        if (addSugar == pitcher.PitcherSize)
                        {
                            sugarInLemonade = addSugar;
                                player.inventory.sugarCubes[0].numInInventory -= addSugar;
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
                player.PlayerChoice();
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
            if(player.inventory.iceCubes[0].numInInventory >= addIce)
            {
                
                iceInLemonade = addIce;
                player.inventory.iceCubes[0].numInInventory -= addIce;
            }
            else
            {
                Console.WriteLine("Insufficient Ice");
                player.PlayerChoice();
            }
        }
        public void MakeAPitcherOFLemonade()
        {
            AddLemonsToLemonade();
            AddSugarToLemonade();
            AddIceToLemonade();
            pitcher.sweetLevel = sugarInLemonade;
            pitcher.sourLevel = lemonsInLemonade;
            pitcher.coldLevel = iceInLemonade;
            pitchers.Add(pitcher);
            pitcher.PrintPitchers();
            
        }
    }
}
