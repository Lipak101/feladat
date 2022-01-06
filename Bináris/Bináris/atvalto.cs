using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bináris
{
    internal class atvalto
    {
        int Szam;
        int Szam2;
        public atvalto(int szam,int szam2)
        {
            this.Szam = szam;
            this.Szam2 = szam2;
                
            
        }

        public void atvalt()
        {
            int number = Szam;
            int remainder;
            int reminder2;
            string result = " ";
            string result2 = " ";
            string[] t = new string[8];
            string[] t2 = new string[8];
            while (Szam > 0 && Szam2 > 0)
            {


                for (int i = 0; i < t.Length; i++)
                {
                    remainder = Szam % 2;
                    Szam /= 2;
                    t[i] = remainder.ToString();
                    result = remainder.ToString() + result;
                }
                for (int i = 0; i < t2.Length; i++)
                {
                    reminder2 = Szam2 % 2;
                    Szam2 /= 2;
                    result2 = reminder2.ToString() + result2;
                    t2[i] = reminder2.ToString();
                }



            }
            Console.Write($"{result}");
            Console.WriteLine();
            Console.Write($"{result2}");
            Console.WriteLine();

            int BinarisSzamlalo = 1;
            int BinarisSzamlalo2 = 1;
            for (int i = 0; i < t.Length; i++)
            {
                if (t[i] == "1")
                {
                    BinarisSzamlalo *= 2;
                }
            }
            for (int i = 0; i < t2.Length; i++)
            {
                if (t2[i] == "1")
                {
                    BinarisSzamlalo2 *= 2;
                }
            }
            Console.Write($"{BinarisSzamlalo}");
            Console.WriteLine();
            Console.Write($"{BinarisSzamlalo2}");
            string[] t3 = new string[8];
            Console.WriteLine();
            //int k = 0;
            //int e = 0;
            //int j = 0;
            //int o = 0;
            //for (e = 0; e < t.Length; e++)
            //{
            //    j = 0;
            //    while (j < t2.Length && t[j] != t2[e])
            //        j++;
            //    if (j < t2.Length)
            //    {
            //        t3[k] = t2[e];
            //        k++;
            //    }
            //}

            //o = k;
            //for (int d = 0; d < o; d++)
            //{
            //    Console.Write($"{t3[d]}");
            //}

        }
    }
}
