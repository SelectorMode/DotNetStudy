using System;

namespace EDU_Module3_ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            var values = Convert.ToInt32(Console.ReadLine());    
           
            for (byte i = 0; i < values; i++)
            {
                Console.WriteLine(FebRecurs(i));
            }
            Console.WriteLine("Pres any key to see next sequence");
            Console.ReadKey();
            
            FebSimple(values);
            Console.ReadKey();
        }
        public static void FebSimple(int values)
        {
            int sum = 0;
            int prev = 0;
            int curr = 0;

            for (byte i = 0; i < values; i++)
            {
                if (i == 0)
                {
                    sum = i;
                    prev = i;
                }
                else if (i == 1)
                {
                    sum = i;
                    curr = i;
                }
                else
                {
                    sum = curr + prev;
                    prev = curr;
                    curr = sum;
                }
                Console.WriteLine(sum);
            }
            Console.ReadKey();
        }

        public static int FebRecurs(int values)
        {
            //  f(n)=f(n-1) + f(n-2), при этом f(0)=0, а f(1)=1.
            if (values == 0)
            {
                return 0;
            }
            if (values == 1)
            {
                return 1;
            }
            else
            {
                return FebRecurs(values - 1) + FebRecurs(values - 2);
            }
        }
    }
}


