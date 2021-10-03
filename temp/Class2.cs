using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace temp2
{
static class Tools
{
    public static int ToInt(this string str)
    {
        return int.Parse(str);
    }
    public static void ToStringProperty<T>(this T t)
    {
        string str = "";
        foreach (PropertyInfo item in t.GetType().GetProperties())
            Console.WriteLine(item.PropertyType);
           // str += "\n" + item.Name + ": " + item.GetValue(t, null);
        Console.WriteLine(str);
    }

}
}
