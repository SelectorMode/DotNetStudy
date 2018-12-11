using System;

namespace LoopFor_ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i<10; i++)
            {                
                if (i == 2) // skip when i=2(3)
                {
                    continue;
                }
                if (i == 5) //stop when i=4(5)
                {
                    break;
                }
                Console.WriteLine("message " + i);
            }
            Console.ReadKey();
        }        
    }
}
