using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Decimal: ");
            int decimalNumber = int.Parse(Console.ReadLine());

            int remainder;
            string result = string.Empty;
            while (decimalNumber > 0)
            {
                remainder = decimalNumber % 2;
                decimalNumber /= 2;
                result = remainder.ToString() + result;
            }

            Console.WriteLine("Binary:  {0}", result);



            Console.Write("Enter the Binary Number : ");
            int binaryNumber = int.Parse(Console.ReadLine());
            int decimalValue = 0;
            
            int base1 = 1;

            while (binaryNumber > 0)
            {
                int reminder = binaryNumber % 10;
                binaryNumber = binaryNumber / 10;
                decimalValue += reminder * base1;
                base1 = base1 * 2;
            }
            Console.Write($"Decimal Value : {decimalValue} ");


           


        }
    }
}
