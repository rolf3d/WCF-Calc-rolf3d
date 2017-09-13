using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCalculator_13_09_2017
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var client = new ServiceReferenceCalculator.Service1Client())
            {
                Console.WriteLine("Add " + client.Add(2,2));

                Console.WriteLine("Multiply " + client.Multiply(2, 2));

                Console.WriteLine("Subtract " + client.Subtract(2, 2));

                Console.WriteLine("Divide " + client.Divide(2, 2));
            }

            Console.ReadLine();
        }
    }
}
