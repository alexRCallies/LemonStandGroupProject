using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSGP
{
    class Day : Game
    {
        // member variables

        public string newCustomer;
        public Weather weather;
        List<string> customer;
        Random random = new Random();


        // Constructor

        public Day()
        {
            
        }


        // member methods

        public void CustomerSelection()
        {
            customer = new List<string>() { "David", "Mark", "Sasha", "Steven", "Ryan", "Leah", "Alex", "Nick", "Mike", "Paul", "Lisa", "Yolanda", "Madonna", "Richard", "Aaron", "Peggy", "Carol", "Lauri", "Sonya", "Suzy", "Marion", "Cliff", "Donald", "Fino", "Mary", "Erica", "Zeek", "Liv" };
            int index = random.Next(customer.Count);
            newCustomer = customer[index];
            Console.WriteLine(newCustomer);

        }
    }
}
