using System;

namespace ForEachParams_ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetSum(1, 2, 3, 4, 5));
            Console.ReadKey();
        }

        static int GetSum(params int[] arrayNumbers)
        {
            int sum = 0;
            foreach (var number in arrayNumbers)
            {
                sum = sum + number;
            }
            return sum;
        }

    }


}
