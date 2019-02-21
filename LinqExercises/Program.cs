using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace LinqExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercise1();
            Exercise2();
            Exercise3();
            Exercise4();
        }

        private static void Exercise1()
        {
            var names = new[] { "Kim", "Kurt", "Karsten", "Klaus", "Kay" };
            var queryResult = names.Select(name => name.Replace("K", "C"));
            Console.WriteLine(string.Join("\n", queryResult));
            Console.WriteLine();
        }

        private static void Exercise2()
        {
            var names = new[] { "Kim", "Kurt", "Karsten", "Klaus", "Kay" };
            var queryResult = names.Select(name => Regex.Replace(name, "[aeiou]\\B", string.Empty, RegexOptions.IgnoreCase));
            Console.WriteLine(string.Join("\n", queryResult));
            Console.WriteLine();
        }

        private static void Exercise3()
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var queryResult = numbers.Select(num => num * 5);
            Console.WriteLine(string.Join("\n", queryResult));
            Console.WriteLine();
        }

        private static void Exercise4()
        {
            const int groupSize = 3;

            var letters = new[] { "a", "b", "c", "d", "e", "f", "g", "h"};
            
            // Calculate number of groups
            var numOfGroups = letters.Length / groupSize;
            if (letters.Length % groupSize > 0)
            {
                numOfGroups++;
            }

            var groups = new List<string[]>(numOfGroups);

            // Split in groups
            for (int i = 0; i < numOfGroups; i++)
            {
                string[] group = letters.Skip(groupSize * i).Take(groupSize).ToArray();
                groups.Add(group);
            }
            
            // Print out
            foreach (string[] group in groups)
            {
                Console.WriteLine(string.Join(" ", group));
            }
        }
    }
}
