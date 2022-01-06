using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bináris
{
    internal class Program
    {
        static void Main(string[] args)
        {
            atvalto atvalt = new atvalto(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            atvalt.atvalt();
            Console.ReadKey();
        }
    }
}
