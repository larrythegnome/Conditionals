using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IfElseStuff();
            Console.ReadLine();
        }

        static void IfElseStuff()
        {
            Console.WriteLine("enter gold amount: ");
            double goldBalance = double.Parse(Console.ReadLine());

            if (goldBalance >= 400)
            {
                Console.WriteLine("heres two ticket.");
            }
            else if (goldBalance >= 200)
            {
                Console.WriteLine("Heres one ticket");
            }
            else 
            {
                Console.WriteLine("Go away");
            }
        }
    }
}
