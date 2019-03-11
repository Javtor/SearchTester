using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchTester
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput = 0;
            do
            {
                userInput = DisplayMenu();
            } while (userInput != 3);
        }

        static public int DisplayMenu()
        {
            Console.WriteLine();
            Console.WriteLine("Search Tester");
            Console.WriteLine();
            Console.WriteLine("1. Add a document");
            Console.WriteLine("2. Query");
            Console.WriteLine("3. Exit");
            var result = Console.ReadLine();
            return Convert.ToInt32(result);
        }
    }
}
