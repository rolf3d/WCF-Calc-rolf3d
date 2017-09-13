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
                Console.WriteLine(client.Add(2,2));
            }

            Console.ReadLine();
        }
    }
}
