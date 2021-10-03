using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex4
{
    class MyException : Exception
    {

    }
    class Program
    {
        static int getAge()
        {
            try
            {
                throw new MyException();
            }
            catch (Exception e)
            {
                Console.WriteLine("Source: " +  e.Source);
                Console.WriteLine("Message: " + e.Message);
                Console.WriteLine("HelpLink: " + e.HelpLink);
                return 0;
            }
            finally
            {
                Console.WriteLine("after catch Block I'm still working");
            }
            Console.WriteLine("after catch Block I'm not working");
        }

        static void Main(string[] args)
        {
            getAge();

           
            double y = 8;
            int x =(int) y;
        }
    }

}
