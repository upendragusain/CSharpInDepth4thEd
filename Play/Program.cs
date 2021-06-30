using System;
using System.Collections;
using System.Collections.Generic;

namespace Play
{
    class Program
    {
        static void Main(string[] args)
        {
            //Action<object> objectAction = obj => Console.WriteLine(obj);
            //Action<string> stringAction = objectAction;

            //stringAction("string");
            //int i;

            //Enumeration.Tests.Run();
            //Enumeration.Tests.RunConversion();

            FuncVariance.Tests.Run();
        }

    }
}
