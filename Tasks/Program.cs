using System;
using System.Linq;
using System.Threading.Tasks;

namespace Tasks
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Count(100, 12);
        }

        public static void Count(int max, int instances)
        {
            for (var i = 0; i < instances; i++)
            {
                Task.Run(() => Console.WriteLine(string.Join(" ", Enumerable.Range(0, max))));
            }
        }
    }
}