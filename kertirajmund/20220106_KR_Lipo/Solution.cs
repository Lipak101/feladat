using System;
using System.Collections.Generic;

namespace _20220106_KR_Lipo
{
    class Solution
    {
        private int firstNumber;
        private List<int> firstNumberBin;
        private string firstNumberBinInt;

        private int secondNumber;
        private List<int> secondNumberBin;
        private string secondNumberBinInt;


        public Solution()
        {
            firstNumberBin = new List<int>();
            secondNumberBin = new List<int>();
        }
        public void Start()
        {
            Console.WriteLine("Decimális:");
            NumbersLoad();
            Console.WriteLine("Bineáris:");
            BinNumbersLoad();
            BinNumbersWriteOut();
            BinNumberOnlyStringToInt();
            Console.WriteLine("Összeadás:");
            Console.WriteLine(TwoNumberPlusString(firstNumberBin, secondNumberBin));
            Console.WriteLine("Kivonás:");
            Console.WriteLine(TwoNumberMinusString(firstNumberBin, secondNumberBin));
        }

        

        private void BinNumbersLoad()
        {
            firstNumberBin = GiveBinList(firstNumber);
            secondNumberBin = GiveBinList(secondNumber);
        }
        private void BinNumbersWriteOut()
        {
            Console.WriteLine(BinNumberString(1,firstNumberBin));
            Console.WriteLine(BinNumberString(2,secondNumberBin));
        }
        private int GiveNumber(int count)
        {
            int number;
            do
            {
                Console.WriteLine($"Kérek az/a {count}. számot!");
                number = int.Parse(Console.ReadLine());
            } while (number >= 255);
            Console.WriteLine($"Az/A {count}. szám értéke: {number}.\n");
            return number;
        }
        private void NumbersLoad()
        {
            firstNumber = GiveNumber(1);
            secondNumber = GiveNumber(2);
        }
        private List<int> GiveBinList(int actualNumber)
        {
            return GiveBinListDo(actualNumber);
        }
        private List<int> GiveBinListDo(int actualNumber)
        {
            List<int> actualNumberBin = new List<int>();


            do
            {
                if (actualNumber % 2 == 1)
                {
                    actualNumberBin.Add(1);
                }
                else
                {
                    actualNumberBin.Add(0);
                }
                actualNumber = actualNumber / 2;
            } while (actualNumber > 0);


            int meddig = 16 - actualNumberBin.Count;
            for (int i = 0; i < meddig; i++)
            {
                actualNumberBin.Add(0);
            }
            return actualNumberBin;
        }
        private string BinNumberString(int count, List<int> BinNumberList)
        { 
            return $"{count}. szám bineárisban: {BinNumberOnlyString(BinNumberList)}\n";
        }
        private string BinNumberOnlyString(List<int> BinNumberList)
        {
            string line = "";
            string goodline = "";
            foreach (var item in BinNumberList)
            {
                line += item.ToString();
            }
            for (int i = line.Length - 1; i > -1; i--)
            {
                goodline += line[i];
            }
            return goodline;
        }
        private void BinNumberOnlyStringToInt()
        {
            firstNumberBinInt = BinNumberOnlyString(firstNumberBin);
            secondNumberBinInt = BinNumberOnlyString(secondNumberBin);
        }
        private string TwoNumberPlusString(List<int> first, List<int> second)
        {
            int sumDec = firstNumber + secondNumber;
            return $"{firstNumberBinInt}\n{secondNumberBinInt}\n\n{firstNumberBinInt}+{secondNumberBinInt}={TwoNumberPlus(first,second)}\n{firstNumber}+{secondNumber}={sumDec}\n";
        }
        private string TwoNumberPlus(List<int> first, List<int> second)
        {
            string[] sumBin = new string[16];
            string allSumBin;
            int j = 0;
            for (int i = first.Count - 1; i > -1; i--)
            {
                if (first[i] == 1 && second[i] == 1)
                {
                    sumBin[j - 1] = "1";
                    sumBin[j] = "0";
                }
                else if (first[i] == 1 || second[i] == 1)
                {
                    sumBin[j] = "1";
                }
                else if (first[i] == 0 && second[i] == 0)
                {
                    sumBin[j] = "0";
                }
                j++;
            }
            allSumBin = All(sumBin);
            return allSumBin;
        }
        private string TwoNumberMinus(List<int> first, List<int> second)
        {
            string[] sumBin = new string[16];
            string allSumBin;
            int borrow=0;
            int j = 0;
            for (int i = first.Count - 1; i > -1; i--)
            {
                if (first[i] == 1 && second[i] == 1)
                {
                    sumBin[j] = "0";
                }
                else if (first[i] == 0 && second[i] == 0)
                {
                    sumBin[j] = "0";
                }
                else if (first[i] == 1 || second[i] == 1)
                {
                    if(first[i] == 0 && second[i] == 1)
                    {
                        borrow++;
                    }
                    sumBin[j] = "1";
                }
                j++;
            }
            j=sumBin.Length-1;
            while (borrow!=0)
            { 
                if(sumBin[j] == "1")
                {
                    sumBin[j-1] = "0";
                    borrow--;
                }
                j--;
            }
            allSumBin = All(sumBin);
            return allSumBin;
        }
        private string TwoNumberMinusString(List<int> first, List<int> second)
        {
            int sumDec = firstNumber - secondNumber;
            return $"{firstNumberBinInt}\n{secondNumberBinInt}\n\n{firstNumberBinInt}-{secondNumberBinInt}={TwoNumberMinus(first, second)}\n{firstNumber}-{secondNumber}={sumDec}\n";
        }
        private string All(string[] all)
        { 
            string sum="";
            for (int i = 0; i < all.Length; i++)
            {
                sum+=all[i];
            }
            return sum;
        }
    }
}
