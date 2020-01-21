using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSGP
{
   static class User_Interface
    {
       public static void Instructions()
        {
            Console.WriteLine("===========================================================================================================");
            Console.WriteLine(" |                               Welcome to Lemonade Stand!                                               |");
            Console.WriteLine(" |                                    Instructions                                                        |");
            Console.WriteLine(" |            Your goal is to make as much money as you can in 7 days by                                  |");
            Console.WriteLine(" |                  selling lemonade at your lemonade stand.                                              |");
            Console.WriteLine(" |       Buy cups, lemons, sugar, and ice cubes, then set your recipe based on                            |");
            Console.WriteLine(" |  the weather and conditions. Start with the basic recipe, but try to vary the recipe                   |");
            Console.WriteLine(" |   and see if you can do better. Lastly, set your price and sell your lemonade at the stand.            |");
            Console.WriteLine(" |           Try changing up the price based on the weather conditions as well.                           |");
            Console.WriteLine(" |          At the end of the game, you'll see how much money you made. Write it down and                 |");
            Console.WriteLine(" |                           play ain to try and beat your score!                                         |");
            Console.WriteLine(" |                                 Ready to play?  Yes or No                                              |");
            Console.WriteLine("===========================================================================================================");
            string confirmation = Console.ReadLine();
            if ((confirmation == "no") || (confirmation == "No") || (confirmation == "NO") || (confirmation == "n")
                || (confirmation == "N") || (confirmation == "nope") || (confirmation == "Nope") || (confirmation == "NOPE") ||
                (confirmation == "NOpe") || (confirmation == "NOPe") || (confirmation == "nOpe"))
            {
                Console.WriteLine("Alright, lets go over the instructions again:");
                Console.Clear();
                Instructions();
            }
            else if ((confirmation == "yes") || (confirmation == "Yes") || (confirmation == "YES") || (confirmation == "y")
                || (confirmation == "Y") || (confirmation == "yup") || (confirmation == "Yup") || (confirmation == "YUP") ||
                (confirmation == "YUp") || (confirmation == "yUp") || (confirmation == "yuP"))
            {
                Console.WriteLine("Great! Lets get started!\n");
                Console.WriteLine("(Press ENTER to CONTINUE)");
                Console.ReadLine();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("That is not a valid answer, Please tray again");
                InstructionRedo();
            }
        }
        static void InstructionRedo()
        {
            Console.WriteLine("\nReady to play?  Yes or No");
            string confirmation = Console.ReadLine();
            if ((confirmation == "no") || (confirmation == "No") || (confirmation == "NO") || (confirmation == "n")
                || (confirmation == "N") || (confirmation == "nope") || (confirmation == "Nope") || (confirmation == "NOPE") ||
                (confirmation == "NOpe") || (confirmation == "NOPe") || (confirmation == "nOpe"))
            {
                Console.WriteLine("Alright, lets go over the instructions again:");
                Instructions();
            }
            else if ((confirmation == "yes") || (confirmation == "Yes") || (confirmation == "YES") || (confirmation == "y")
                || (confirmation == "Y") || (confirmation == "yup") || (confirmation == "Yup") || (confirmation == "YUP") ||
                (confirmation == "YUp") || (confirmation == "yUp") || (confirmation == "yuP"))
            {
                Console.WriteLine("Great! Lets get started!\n");
            }

        }
    }
}
