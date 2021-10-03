using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex5
{
    partial class MyClass
    {
        partial void f1()
        {
            this.X = 9;
            Console.WriteLine("run f1: ...");
        }
    }


}
