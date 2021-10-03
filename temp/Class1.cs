using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace temp
{
partial class MyClass
{
    dynamic d;

    public dynamic D
    {
        get { return d; }
        set { d = value; }
    }

    partial void f1()
    {
        Console.WriteLine("run f1: ...");
    }  
}

partial class MyClass
{
    partial void f1(); 

    public MyClass()
    {
        f1();
    }
}
    
}
