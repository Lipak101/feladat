using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeladatokDeMorgan
{
    class Feladat
    {
        private int a;
        private int b;

        public Feladat(int a, int b)
        {
            if (a > 1 || a < 0)
            {
                a = 1;
            }
            if (b > 1 || b < 0)
            {
                b = 1;
            }
            this.a = a;
            this.b = b;
        }

        public void DeMorgan()
        {
            Console.WriteLine($"A bitek: A - {a}, B - {b}");

            Console.WriteLine("1. azonosság: ¬(A ∨ B)= ¬A ∧ ¬B");
            Console.Write("Eredménye: ");
            Console.WriteLine(ElsoAzonossag());

            Console.WriteLine();

            Console.WriteLine("2. azonosság: ¬(A ∨ B)= ¬A ∧ ¬B");
            Console.Write("Eredménye: ");
            Console.WriteLine(MasodikAzonossag());
        }

        public int ElsoAzonossag()
        {
            bool abool = a == 1;
            bool bbool = b == 1;
            bool resultone = !(abool || bbool) == (!abool) && (!bbool);
            return resultone ? 1 : 0;
        }

        public int MasodikAzonossag()
        {
            bool abool = a == 1;
            bool bbool = b == 1;
            bool resulttwo = !(abool && bbool) == (!abool) || (!bbool);
            return resulttwo ? 1 : 0;
        }
    }
}
