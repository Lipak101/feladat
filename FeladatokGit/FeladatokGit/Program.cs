using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeladatokGit
{
    class Program
    {
        static void Main(string[] args)
        {
            Feladat f = new Feladat(1,1);
            f.DeMorgan();

            Console.ReadKey();
        }
    }
}
