using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSGP
{
   public class Lemon : Items
    {
        
        public Lemon() //Liskovs Rule: we can easily switch this with its parent class and it would be identical essentially -Alex
        {
            name = "Lemon";
            price = 1;
            numInInventory = 0; 

        }
    }
}
