using AssistMeProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchTester
{
    class Program
    {

        public BaseClass bc;

        Program()
        {
            bc = new BaseClass();
            int userInput = 0;
            do
            {
                userInput = DisplayMenu();
                switch (userInput)
                {
                    case 1:
                        AddDocument();
                        break;
                    case 2:
                        Query();
                        break;
                    case 3:
                        SeeDocuments();
                        break;
                }
            } while (userInput != 3);
        }

        private void SeeDocuments()
        {
            int counter = 1;
            foreach(Document doc in bc.Docs)
            {
                Console.WriteLine("Document #" + counter);
                Console.WriteLine(doc);
                Console.WriteLine();
                counter++;
            }
        }

        static void Main(string[] args)
        {
            new Program();
        }

        private static void Query()
        {
            throw new NotImplementedException();
        }

        private static void AddDocument()
        {
            Console.WriteLine("Write \"0 0\" to stop writing");
            string line = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            while(line != "0 0")
            {
                sb.Append(line);
                line = Console.ReadLine();
            }
        }

        static public int DisplayMenu()
        {
            Console.WriteLine();
            Console.WriteLine("Search Tester");
            Console.WriteLine();
            Console.WriteLine("1. Add a document");
            Console.WriteLine("2. Query");
            Console.WriteLine("3. See Documents");
            Console.WriteLine("4. Exit");
            var result = Console.ReadLine();
            return Convert.ToInt32(result);
        }
    }
}
