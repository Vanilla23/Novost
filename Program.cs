using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = int.Parse(Console.ReadLine());
            var y = double.Parse(Console.ReadLine());
            var z = int.Parse(Console.ReadLine());
            var w = int.Parse(Console.ReadLine());
            double sum = x * y;
            double zavino = Math.Abs((0.6 * sum) / 2.5);
            double kaksme = Math.Abs(zavino - z);
            double delenie = Math.Abs(kaksme / w);

            if (zavino >= z)
            {
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.", Math.Floor(zavino));
                Console.WriteLine("{0} litersleft ->{1} liters per person", Math.Ceiling(kaksme), Math.Ceiling(delenie));
            }
            else
            {
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed", Math.Floor(zavino));
            }

        }
    }
}
