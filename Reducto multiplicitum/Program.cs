using System;

namespace SumDigProdCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 16;
            int num2 = 28;

            int product = SumDigProd(num1, num2);

            Console.WriteLine($"Product of the sums: {product}");
        }

        static int SumDigProd(int num1, int num2)
        {
            int firstSum = num1 + num2;

            while (firstSum >= 10)
            {
                int multiplySum = 1;
                while (firstSum > 0)
                {
                    int digit = firstSum % 10;
                    multiplySum *= digit;
                    firstSum /= 10;
                }
                firstSum = multiplySum;
            }

            return firstSum;
        }
    }
}
