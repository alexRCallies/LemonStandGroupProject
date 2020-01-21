using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSGP
{
   public class Inventory
    {
        // member variables 
        public Lemon lemon = new Lemon();
        public Ice_Cube iceCube = new Ice_Cube();
        public Sugar_Cube sugarCube = new Sugar_Cube();
        public Cup cup = new Cup();
        public Pitcher pitcher = new Pitcher();
        public List<Lemon> lemons = new List<Lemon>();
        public List<Ice_Cube> iceCubes = new List<Ice_Cube>();
        public List<Cup> cups = new List<Cup>();
        public List<Sugar_Cube> sugarCubes = new List<Sugar_Cube>();
        public List<Pitcher> pitchers = new List<Pitcher>();
        // constructor
        public Inventory()
        {
            pitchers.Add(pitcher);
            lemons.Add(lemon);
            iceCubes.Add(iceCube);
            sugarCubes.Add(sugarCube);
            cups.Add(cup);
        }
        
        
            
        // member methods
        public void ShowCurrentInventory()
        {
            Console.WriteLine("\nHere is your current inventory.");
            foreach(Lemon lemon in lemons)
            {
                Console.WriteLine(lemon.name+": "+lemon.numInInventory);
            }
            foreach(Sugar_Cube sugarCube in sugarCubes)
            {
                Console.WriteLine(sugarCube.name+": "+sugarCube.numInInventory);
            }
            foreach(Ice_Cube iceCube in iceCubes)
            {
                Console.WriteLine(iceCube.name+": "+iceCube.numInInventory);
            }
            foreach(Cup cup in cups)
            {
                Console.WriteLine(cup.name+": "+cup.numInInventory);
            } 
                
        }
        public void PrintPitchers()
        {
            foreach (Pitcher pitcher in pitchers)
            {
                Console.WriteLine($"Pitcher  Sour Level: " + pitcher.sourLevel + " Sweet Level: " + pitcher.sweetLevel + " Cold Level: " + pitcher.coldLevel + " Number of Pitchers:" + pitcher.numOfPitchers);
            }

        }

    }
}
