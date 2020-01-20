using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSGP
{
    class Day
    {
        // member variables

        int dayCounter = 7;
        public Weather weather;
        List<Customer> customer;
        Customer aaron;
        Customer alex;
        Customer david;
        Customer leah;
        Customer lisa;
        Customer madonna;
        Customer mark;
        Customer mike;
        Customer nick;
        Customer paul;
        Customer richard;
        Customer ryan;
        Customer sasha;
        Customer steven;
        Customer yolanda;
        List<Customer> customers = new List<Customer>();

        public int weatherAdjust;

        // Constructor

        public Day()
        {
            this.aaron = new Customer("A-a-ron", 14, 15, 15, 15, 15, 5);
            this.alex = new Customer("Alex", 21, 16, 14, 15, 15, 4);
            this.david = new Customer("David", 32, 17, 14, 14, 14, 6);
            this.leah = new Customer("Leah", 15, 17, 5, 16, 15, 4);
            this.lisa = new Customer("Lisa", 28, 14, 15, 16, 17, 5);
            this.madonna = new Customer("Madonna", 55, 14, 16, 15, 14, 3);
            this.mark = new Customer("Mark", 24, 16, 14, 15, 14, 5);
            this.mike = new Customer("Mike", 33, 14, 15, 16, 17, 4);
            this.nick = new Customer("Nick", 41, 16, 16, 16, 16, 5);
            this.paul = new Customer("Paul", 45, 15, 14, 15, 14, 5);
            this.richard = new Customer("Richard", 25, 13, 17, 17, 17, 6);
            this.ryan = new Customer("Ryan", 70, 13, 16, 16, 16, 8);
            this.sasha = new Customer("Sashe", 37, 16, 13, 15, 15, 4);
            this.steven = new Customer("Steven", 43, 17, 15, 14, 15, 4);
            this.yolanda = new Customer("Yolanda", 53, 15, 15, 15, 15, 5);
            customers.Add(aaron);
            customers.Add(alex);
            customers.Add(david);
            customers.Add(leah);
            customers.Add(lisa);
            customers.Add(madonna);
            customers.Add(mark);
            customers.Add(mike);
            customers.Add(nick);
            customers.Add(paul);
            customers.Add(richard);
            customers.Add(ryan);
            customers.Add(sasha);
            customers.Add(steven);
            customers.Add(yolanda);
        }


        // member methods
        public void runDay()
        {
            weather.MasterForecast();
            weather.ActualDayWeather();

            foreach (Customer customer in customers)
            {
                if (weather.condition == "Sunny")
                {
                    customer.chanceToGoToStand += 2;

                }
                else if (weather.condition == "Rainy")
                {
                    customer.chanceToGoToStand -= 3;
                }
                else if (weather.condition == "Thunder Storm")
                {
                    customer.chanceToGoToStand -= 10;
                }
            }
        }
    }
}
