using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncVariance
{
    public class Tests
    {
        public static void Run()
        {
            Func<object, int> func1 = obj => { return Convert.ToInt32(obj); };
            Func<string, int> func2 = str => { return Convert.ToInt32(str); };

            object o = 1;
            Console.WriteLine(func1(o));
            Console.WriteLine(func2("1"));

            Func<string, int> func3 = func1; // string to object implicit reference conversion, and int to int identity conversion
            Console.WriteLine(func3("1"));
        }

        public static void Run2()
        {
            Func<string, int> func1 = str => { return Convert.ToInt32(str); };
            //Func<object, int> func2 = func1; // no implicit reference converison from object to string, second type (int) doesn't matter as first rule failed
        }
    }
}
