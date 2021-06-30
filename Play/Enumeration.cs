using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeration
{
    //https://stackoverflow.com/questions/11296810/how-do-i-implement-ienumerablet

    public class Employee
    {
        public Employee(int id)
        {
            Id = id;
        }
        public int Id { get; }
    }

    public class EmployeeCollection : IEnumerable<Employee>
    {
        private List<Employee> _employees = new();

        public Employee this[int index]
        {
            get { return _employees[index]; }
            set { _employees.Insert(index, value); }
        }

        public IEnumerator<Employee> GetEnumerator()
        {
            return _employees.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class SimpleEnumerator<T> : IEnumerable<T>
    {
        private List<T> _list = new();

        public T this[int index]
        {
            get { return _list[index]; }
            set { _list.Insert(index, value); }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _list.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class Tests
    {
        public static void Run()
        {
            EmployeeCollection employees = new EmployeeCollection();
            employees[0] = new Employee(1);
            employees[1] = new Employee(2);

            foreach (var employe in employees)
            {
                Console.WriteLine(employe.Id);
            }
        }

        public static void RunConversion()
        {
            var strCollection = new SimpleEnumerator<string>();
            strCollection[0] = "1";
            strCollection[1] = "2";

            foreach (var str in strCollection)
            {
                Console.WriteLine(str);
            }

            //complie time error, 
            // 4.4.3
            // As varianxce isn't inherited by classes or structs implementing inetrfaces; classes and structs are always invariant.
            //SimpleEnumerator<object> objCollection = strCollection;

            //however can use covariance of IEnumerable<T>
            IEnumerable<object> objCollection2 = strCollection;
            foreach (var obj in objCollection2)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
