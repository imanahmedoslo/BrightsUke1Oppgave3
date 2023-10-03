using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BrightsUke1
{
    internal class Program
    {
       
       
        static void Main(string[] args)
        {
            categorizePeople();

            Console.ReadKey();


        }
    
       
        /*
         * Task 1.3
Categorizing people 
Write a program that asks the user for 2 different persons' names (one at a time, so 2 inputs
        Then asks for each persons' age, by using their name. Finally display a sentence stating who is older, 
        or if they are of equal age.
Examples: (it is ok if your texts are somewhat different, this is just one way of doing it)
         
         */
        public static void categorizePeople()
        {
            Console.WriteLine("Welcome! can you give me 2 names, one at a time?");
            var name1= Console.ReadLine();
            var name2= Console.ReadLine();
            Console.WriteLine("wonderful! Now how old is "+ name1 + " ?");
            var age1=int.Parse(Console.ReadLine());
            Console.WriteLine("and what about " + name2 + " ?");
            var age2= int.Parse(Console.ReadLine());
            person person1= new person(name1, age1 );
            person person2= new person(name2, age2 );
            Console.WriteLine(person1.Name);
            person1.rankAge(person2);
        }

    }
    
   
}

