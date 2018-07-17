using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drips
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many drip drops do you hear per second?");
            double drip_drops = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("This wastes " + 3600/drip_drops*0.00025 + " litres per hour");
            Console.WriteLine("This wastes " + 86400 / drip_drops * 0.00025 + " litres per hour");
            Console.WriteLine("This wastes " + 604800 / drip_drops * 0.00025 + " litres per hour");
            Console.Read();
        }
    }
}
