using System;

namespace StringIsNull_ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = null;
            string str2 = "some text";
            // check if string == null
            string result1 = str1 ?? "srt1 contains null";
            string result2 = str2 ?? "srt2 contains null";
                       
            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.ReadKey();

        }
    }
}
