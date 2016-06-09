using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i<1000; i++)
            {
                Employee emp = new Employee
                {
                    Id = i,
                    Name = "Ivan Deynega"
                };
                Console.WriteLine(emp.ToString());
            }
                Console.WriteLine("Welcome to test SB...");
            Console.WriteLine("Test new");
            Console.ReadKey();
        }
    }
}
