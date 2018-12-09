using System;

namespace Switch_ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            string text = Console.ReadLine();
            int x = Convert.ToInt32(text);

            switch (x)
            {
                case 1:
                    Console.WriteLine("Number is 1");
                    break;
                case 2:
                    Console.WriteLine("Number is 2");
                    break;
                case 3:
                    Console.WriteLine("Number is 3");
                    break;
                case 4: // 4 and 1
                    Console.WriteLine("Number is 4");
                    Console.WriteLine("And also take");
                    goto case 1;
                case 5: // 5 or 6
                case 6:
                    Console.WriteLine("Number is 5 or 6");
                    break;
                default:
                    Console.WriteLine("Number is out of list");
                    break;
            }

            Console.WriteLine("The End");
            Console.ReadKey();
        }
    }
}
