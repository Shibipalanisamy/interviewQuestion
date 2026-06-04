using System;
using System.Collections.Generic;
using System.Text;

namespace Partices.Basic
{
    public static class ExtensionMethodClass
    {
        public static string ExtensionMethod(this int number)
        {
            return number % 2 == 0 ? "Even" : "Odd";
        }
    }

    class A
    {
        public void test()
        {
            string a = "test parent";
            Console.WriteLine("Class " + a);
        }
    }
    class B : A
    {
        public void test()
        {
            string a = "test cjhild";

            Console.WriteLine("Class " + a);
        }
    }
}
