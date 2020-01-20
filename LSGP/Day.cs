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

        
        public Weather weather;
        List<Customer> customer;
        Aaron aaron;
        Alex alex;
        David david;
        Leah leah;
        Lisa lisa;
        Madonna madonna;
        Mark mark;
        Mike mike;
        Nick nick;
        Paul paul;
        Richard richard;
        Ryan ryan;
        Sasha sasha;
        Steven steven;
        Yolanda yolanda;
        List<Customer> customers = new List<Customer>();

        public int weatherAdjust;

        // Constructor

        public Day()
        {
            this.aaron = new Aaron();
            this.alex = new Alex();
            this.david = new David();
            this.leah = new Leah();
            this.lisa = new Lisa();
            this.madonna = new Madonna();
            this.mark = new Mark();
            this.mike = new Mike();
            this.nick = new Nick();
            this.paul = new Paul();
            this.richard = new Richard();
            this.ryan = new Ryan();
            this.sasha = new Sasha();
            this.steven = new Steven();
            this.yolanda = new Yolanda();
            customer.Add(aaron);
            customer.Add(alex);
            customer.Add(david);
            customer.Add(leah);
            customer.Add(lisa);
            customer.Add(madonna);
            customer.Add(mark);
            customer.Add(mike);
            customer.Add(nick);
            customer.Add(paul);
            customer.Add(richard);
            customer.Add(ryan);
            customer.Add(sasha);
            customer.Add(steven);
            customer.Add(yolanda);
        }


        // member methods

    }
}
