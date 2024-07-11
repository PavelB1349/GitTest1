using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTestApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = 3;
            var b = 6;
            var c = 12;

            Console.WriteLine($"Result = {a + b + c}");

            Console.WriteLine("После коммита");
            Console.WriteLine("newWork");
            Console.ReadKey();
        }
    }
}
