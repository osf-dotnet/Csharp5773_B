using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex3
{
    class Program
    {
        static int getAge()
        {
            try
            {
                Console.WriteLine("enter your age");
                string ageStr = Console.ReadLine();
                int age = int.Parse(ageStr);
                return age;
            }
            catch
            {
                Console.WriteLine("Please enter only numbers");
                return 0;
            }
            finally
            {
                Console.WriteLine("finally….");
            }
            Console.WriteLine("after Block I'm not working");
        }

        static void Main(string[] args)
        {
            while (getAge() == 0) ;

        }

    }
}
