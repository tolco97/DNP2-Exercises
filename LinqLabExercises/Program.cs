using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace LinqLabExercises
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(string.Join("\n", CreateCustomers()));
            XMLQuery();
        }

        private static IEnumerable<Customer> CreateCustomers()
        {
            return from c in XDocument.Load($"{AppDomain.CurrentDomain.BaseDirectory}/Customers.xml").Descendants("Customers").Descendants()
                select new Customer {City = c.Attribute("City").Value, CustomerID = c.Attribute("CustomerID").Value};
        }

        public static void XMLQuery()
        {
            var doc = XDocument.Load($"{AppDomain.CurrentDomain.BaseDirectory}/Customers.xml").Descendants("Customers").Descendants();
            var results = from c in doc.Descendants("Customer") where c.Attribute("City").Value == "London" select c;
            Console.WriteLine("Results:\n");
            foreach (var contact in results)
            {
                Console.WriteLine("{0}\n", contact);
            }
        }

    }
}