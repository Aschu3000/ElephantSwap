using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElephantSwap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Elephant lucinda = new Elephant() { Name = "Lucinda", EarSize = 33 };
            Elephant llyod = new Elephant() { Name = "Lloyd", EarSize = 40 };

            Console.WriteLine("Press 1 for Llyod, 2 for Lucinda, 3 to swap");
            while (true)
            {
                char input = Console.ReadKey(true).KeyChar;
                Console.WriteLine("You pressed " + input);
                if (input == '1')
                {
                    Console.WriteLine("Calling Lloyd.WhoAmI()");
                    llyod.WhoAmI();
                }
                else if (input == '2')
                {
                    Console.WriteLine("Calling Lucinda.WhoAmI()");
                    lucinda.WhoAmI();
                }
                else if (input == '3')
                {
                    Console.WriteLine("References have been swapped");
                    Elephant holder;
                    holder = llyod;
                    llyod = lucinda;
                    lucinda = holder;
                }
                else return;
                Console.WriteLine();
            }
        }
    }
}
