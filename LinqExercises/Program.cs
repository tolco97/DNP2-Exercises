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
            var withoutK = names.Select(name => name.Replace("K", "C"));
            Console.WriteLine(string.Join("\n", withoutK));
            Console.WriteLine();
        }

        private static void Exercise2()
        {
            var names = new[] { "Kim", "Kurt", "Karsten", "Klaus", "Kay" };
            var withoutVowels = names.Select(name => Regex.Replace(name, "[aeiou]\\B", ""));
            Console.WriteLine(string.Join("\n", withoutVowels));
            Console.WriteLine();
        }

        private static void Exercise3()
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var multipliedBy5 = numbers.Select(num => num * 5);
            Console.WriteLine(string.Join("\n", multipliedBy5));
            Console.WriteLine();
        }

        private static void Exercise4()
        {
            var letters = new[] { "a", "b", "c", "d", "e", "f", "g", "h"};
            
            // Calculate number of groups
            var numOfGroups = letters.Length / 3;
            if (letters.Length % 3 > 0)
            {
                numOfGroups++;
            }

            var groups = new List<string[]>(numOfGroups);

            for (int i = 0; i < numOfGroups; i++)
            {
                var group = letters.Skip(3 * i).Take(3).ToArray();
                groups.Add(group);
            }
            
            foreach (string[] group in groups)
            {
                Console.WriteLine(string.Join(" ", group));
            }
        }
    }
}
