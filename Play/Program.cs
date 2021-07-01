using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

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

            //IEnumerable<string> strings = new[] { "a" , "b", "c"};
            //IEnumerable<object> objects = strings;
            ////ICollection<object> lObjects = objects;
            ////lObjects.Add

            //List<object> objects2 = strings.Where(_ => _.Length >= 1).ToList<object>();

            //FuncVariance.Tests.Run();

            ContravariantComparison.Run();
        }

    }
}
