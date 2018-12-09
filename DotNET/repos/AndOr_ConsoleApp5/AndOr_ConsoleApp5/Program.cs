using System;

namespace AndOr_ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int x = Convert.ToInt32(text);
            if ((x > 10) && (x < 20))
            {
                Console.WriteLine("x between 10 and 20");
            }
            if ((x < 10) || (x > 20))
            {
                Console.WriteLine("x out of bounds 10 and 20");
            }
            Console.ReadKey();           
        }
    }
}
