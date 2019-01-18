using Features.Linq;
using System;
using System.Collections.Generic;

namespace Features
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Employee> developers = new Employee[]
            {
                new Employee { Id = 1, Name = "Scott" },
                new Employee { Id = 2, Name = "Chris" }
            };

            var sales = new List<Employee>()
            {
                new Employee { Id = 3, Name = "Alex" }
            };

            foreach (var person in developers)
            {
                Console.WriteLine(person.Name);
            }

            foreach (var person in sales)
            {
                Console.WriteLine(person.Name);
            }

            Console.WriteLine("*****");

            IEnumerator<Employee> enumerator = developers.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current.Name);
            }

            IEnumerator<Employee> enumerator1 = sales.GetEnumerator();
            while (enumerator1.MoveNext())
            {
                Console.WriteLine(enumerator1.Current.Name);
            }

            Console.WriteLine($"developers.Count() = {developers.Count()}");
            Console.WriteLine($"sales.Count() = {sales.Count()}");

            Console.ReadKey();
        }
    }
}
