using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex1
{
    class Program
    {

        static int getAge()
        {
            Console.WriteLine("enter your age");
            string ageStr = Console.ReadLine();
            int age = int.Parse(ageStr);
            return age;
        }

        static void Main(string[] args)
        {
            while (getAge() == 0) ;
        }

    }
}
    