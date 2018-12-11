using System;

namespace Array_ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            //instant initialization 
            int[] arr = new int[3] { 1, 2, 3 };
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Array arr " + i + " " + arr[i]);
            }

            // int length = 5;
            string[] array = new string[5];
            // manual insert into array
            array[0] = "Dog";
            array[1] = "Cat";
            array[2] = "Empty";
            array[3] = "Empty";
            array[4] = "Empty";
            // loop read from array
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(i + " " + array[i]);
            }
            // loop insert into array
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToString(i);
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(i + " " + array[i]);
            }

            Console.ReadKey();
        }
        
    }
}
