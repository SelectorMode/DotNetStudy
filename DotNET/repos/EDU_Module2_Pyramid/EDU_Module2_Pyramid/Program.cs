using System;

namespace EDU_Module2_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a simple program, that displays a pyramid in the console.
            // Set number of rows as a variable:
            // var rows = 7;
            // Please, follow codestyles. 

            // incrfeasing
            //for (int i = 0; i < rows; i++)
            //{
            //    //for (int j = columns - i; j < columns + 1; j++)
            //    for (int j = 0; j <= i; j++)
            //    {
            //        Console.Write('*');
            //    }
            //    Console.WriteLine();
            //}

            // decriasing
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < columns - i; j++)
            //    {
            //        Console.Write('*');
            //    }
            //    Console.WriteLine();
            //}

            //decriasing more clear
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = i; j < rows; j++)
            //    //for (int j = columns; j > i; j--)
            //    {
            //        Console.Write('*');
            //    }
            //    Console.WriteLine();
            //}

            //together
            var rows = 7;

            for (int i = 0; i < rows; i++)
            {

                for (int j = i; j < rows; j++)
                {
                    Console.Write(' ');
                }

                for (int j = 0; j <= i * 2; j++)
                {
                    Console.Write('*');
                }

                Console.WriteLine();
            }


            Console.WriteLine("Press any key to continue . . .");
            Console.ReadKey();

        }
    }
}


