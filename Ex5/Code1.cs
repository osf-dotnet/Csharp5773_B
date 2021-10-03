using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex5
{
    partial class MyClass
    {
        public int X { get; set; }

        partial void f1();

        public MyClass()
        {
            f1();
        }
    }

}
