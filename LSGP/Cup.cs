﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSGP
{
   public class Cup : Items
    {
       public int numOfCupsInAPack = 20;
        public int numInInventory;
        public Cup()
        {
            name = "Cups";
            price = 5;
        }
    }
}
