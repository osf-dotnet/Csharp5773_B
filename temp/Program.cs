using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using temp2;
using System.Collections;
using System.Xml.Linq;

namespace temp
{

    static class Tools
    {
        public static int ToInt(this string str)
        {
            return int.Parse(str);
        }

    }

    partial class Program
    {
        partial void f1();
public static dynamic Sum(params dynamic[] arg)
{
    if (arg.Length ==0)
        return 0;

    dynamic sum=arg[0];
    foreach (var item in arg)
        sum += item;

    return sum;
}

public static object getNull()
{
    return null;
}

static void Main(string[] args)
{
    MyClass m = new MyClass {D = 67 };

    dynamic d;
    //d = 6;
    //Console.WriteLine(d.GetType());


    int x = 6;
    d = x;
    // d = "123";
    Console.WriteLine(d);
  
    
    
    
    d = DateTime.Now;
    Console.WriteLine(d.GetType());

    var v = getNull();

  
}
    }
}
