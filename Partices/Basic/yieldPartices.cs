using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.VisualBasic;

namespace Partices.Basic
{
    public class yieldPartices
    {

        public void printallCountry()
        {
            yieldPartices partices = new yieldPartices();
            foreach (string part in partices.withoutYieldprintCountry("u"))
            {
                Console.WriteLine(part);
            }
        }
        public IEnumerable<string> withoutYieldprintCountry(string country)
        {
            List<string> resultList = new List<string>();
            List<string> AllpoductCountryList = new List<string>() { "UK", "US", "Europ", "India" };
            for (int i = 0; i < AllpoductCountryList.Count; i++)
            {
                if (AllpoductCountryList[i].ToLower().Contains(country))
                {
                    Console.WriteLine(AllpoductCountryList[i]);
                    resultList.Add(AllpoductCountryList[i]);

                }
            }
            return resultList;
        }
        public IEnumerable<string> withYieldprintCountry(string ch)
        {
            List<string> ll = new List<string>() { "UK", "US", "India", "Europ" };
            for (int i = 0; i < ll.Count; i++)
            {
                {
                    if (ll[i].ToLower().Contains(ch))
                    {
                        yield return ll[i];
                    }
                }
            }
        }
    }

    class Animal : iAnimal
    {
        public void sleep()
        {

        }
        public void Eat() {
            Console.WriteLine("Animal will eat");
        }
    }
    class Dog:Animal
    {
        public void bark()
        {
            Console.WriteLine("Dog will bark");
        }
        
    }
    interface iAnimal
    {
       const int i=10;
        void sleep();
    }
}
