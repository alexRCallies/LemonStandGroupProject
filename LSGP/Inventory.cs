using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSGP
{
   class Inventory
    {
        // member variables 
        Lemon lemon = new Lemon();
        Ice_Cube iceCube = new Ice_Cube();
        Sugar_Cube sugarCube = new Sugar_Cube();
        Cup cup = new Cup();
        public List<Lemon> lemons = new List<Lemon>() { };
        public List<Ice_Cube> iceCubes =new List<Ice_Cube>() { };
        public List<Cup> cups = new List<Cup>() { };
        public List<Sugar_Cube> sugarCubes = new List<Sugar_Cube>() { };

        // constructor
        public Inventory()
        {
            lemons.Add(lemon);
            iceCubes.Add(iceCube);
            sugarCubes.Add(sugarCube);
            cups.Add(cup);
        }
        
        
            
        // member methods
        public void ShowCurrentInventory()
        {
            Console.WriteLine("You Have: ");
            foreach(Lemon lemon in lemons)
            {
                Console.WriteLine(lemon.name+" "+lemon.numInInventory);
            }
            foreach(Sugar_Cube sugarCube in sugarCubes)
            {
                Console.WriteLine(sugarCube.name+" "+sugarCube.numInInventory);
            }
            foreach(Ice_Cube iceCube in iceCubes)
            {
                Console.WriteLine(iceCube.name+" "+iceCube.numInInventory);
            }
            foreach(Cup cup in cups)
            {
                Console.WriteLine(cup.name+" "+cup.numInInventory);
            } 
                
        }

    }
}
