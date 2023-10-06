using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrightsUke1
{
    public class person
    {
        public string Name;
        public int Age;

        public person(string name, int age)
        {
            Name=name;
            Age = age;

        }
        public void rankAge( person comparingPartner)
        {
            if (Age > comparingPartner.Age)
            {
                Console.WriteLine (Name+ " is older than " + comparingPartner.Name);
            } else if(Age < comparingPartner.Age)
            {
                Console.WriteLine (comparingPartner.Name+ " is older than " + Name);
            } else { Console.WriteLine("they are both the same age ^^"); }
        }
    }
    
}
