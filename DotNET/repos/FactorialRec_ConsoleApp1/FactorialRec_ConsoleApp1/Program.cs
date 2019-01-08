using System;

namespace FactorialRec_ConsoleApp1
{
    class Factorial
    {
        public int FactR(int n)
        {
            if (n == 1)
            {
                Console.WriteLine("Из FactR(" + n + ") не вызываем больше.");
                Console.WriteLine("FactR(" + n + ") возвращает " + 1);
                return 1;
            }
            Console.WriteLine("Из FactR(" + n + ") вызываем FactR(" + (n - 1) + ")");
            int result = FactR(n - 1) * n;
            Console.WriteLine("FactR(" + n + ") возвращает " + (result / n) + " * " + n + " = " + result);
            return result;
        }
    }

    class Program
    {
        static void Main()
        {
            Factorial f = new Factorial();
            Console.WriteLine("\nФакториал числа 5 равен " + f.FactR(5));

            Console.ReadLine();
        }
    }
}
