using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSGP
{
   public class Pitcher
    {
        public int cupsPerPitcher;
       
        public int PitcherSize = 6;
        public int sourLevel;
        public int sweetLevel;
        public int coldLevel;
        public List<Pitcher> pitchers = new List<Pitcher>();
        
        public Pitcher()
        {
            this.cupsPerPitcher = 15;
            
        }
        public void PrintPitchers()
        {
            foreach(Pitcher pitcher in pitchers)
            {
                Console.WriteLine($"Pitcher  Sour Level: " +sourLevel+ " Sweet Level: " +sweetLevel+ " Cold Level: " + coldLevel);
            }
            
        }

    }
}
