using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSGP
{
   public class Player
    {
        public string name;
        public Wallet wallet;
        public string input;
       public Recipe recipe;
        public Inventory inventory;
        public Pitcher pitcher;
        

        public Player()
        {
            inventory = new Inventory();
            wallet = new Wallet();
            recipe = new Recipe(inventory) ;
            pitcher = new Pitcher();
        }
            
        
    }
}
