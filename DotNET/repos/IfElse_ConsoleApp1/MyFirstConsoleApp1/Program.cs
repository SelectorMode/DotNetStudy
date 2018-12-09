using System;

namespace MyFirstConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {            
            string text = Console.ReadLine();
            int years = Convert.ToInt32(text);
            if (years > 16)
            {
                Console.WriteLine("Student");
            }
            else
            {
                Console.WriteLine("Peupil");
            }
            
            Console.ReadKey();
        }
    }
}
