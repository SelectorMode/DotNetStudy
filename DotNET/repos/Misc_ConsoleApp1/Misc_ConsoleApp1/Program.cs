using System;

namespace Misc_ConsoleApp1
{
    class Program
    {
        static void SomeMethod(out int a, ref int b)
        {
            var random = 42;
            a = random / 2;
            b = random;
        }
        static void Main(string[] args)
        {
            int a=0;
            int b=0;
            SomeMethod(out a, ref b);
            Console.WriteLine("a {0}" ? a);
            Console.WriteLine("b: {0}", b);
            Console.ReadLine();
        }
    }
}
