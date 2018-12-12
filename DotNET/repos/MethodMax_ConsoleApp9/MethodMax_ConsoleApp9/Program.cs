using System;

namespace MethodMax_ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        { 
            int res;
            NumberManipulator numberManipulator = new NumberManipulator();

            res = numberManipulator.FindMax(30, 20);

            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
class NumberManipulator
    {
        public int FindMax(int first, int second)

        {
            int result;
            if (first > second)
            {
                result = first;
            }
            else
            {
                result = second;
            }
            return result;

        }

    }
}
