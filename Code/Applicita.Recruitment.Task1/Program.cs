using System;
using System.Collections.Generic;

namespace Applicita.Recruitment.Task1
{
    internal class Program
    {
        private static void Main()
        {
            var items = new List<string>
                        {
                            "Adam",
                            "Bill",
                            "Bob",
                            "Eddy",
                            "John",
                            "Mike"
                        };

            IEnumerable<string> selectedItems = items.Where(item => item.StartsWith("B"));

            foreach(string item in selectedItems)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Complete. Press any key to exit.");
            Console.ReadKey();
        }
    }
}