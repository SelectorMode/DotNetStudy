using System;

namespace TernarOper_ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            string text = Console.ReadLine();
            int x = Convert.ToInt32(text);
            // ternar operator
            string result = x > 16 ? "Greater 16" : "Less 16";
            Console.WriteLine("Result is " + result);
            Console.ReadKey();

        }
    }
}
