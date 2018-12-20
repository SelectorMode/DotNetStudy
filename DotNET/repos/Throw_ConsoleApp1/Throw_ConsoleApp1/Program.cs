using System;

namespace Throw_ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int ourmoney = OurMoney(10, 10);
            int everyonesMoney = EveryonesMoney();

            //Console.WriteLine();
            //Console.ReadKey();
        }

        public static int EveryonesMoney()
        {
            int everyonesMoney = 0;

            try
            {
                everyonesMoney = TheirMoney(-20, 20) + OurMoney(10, 10);
            }
            catch (Exception)
            {
                throw;
            }

            return everyonesMoney;
           
        }


        public static int TheirMoney(int hisMoney, int herMoney)
        {
            if (hisMoney < 0 || herMoney < 0) throw new ArithmeticException("Their money value is not valid");
            return hisMoney + herMoney;
        }

        public static int OurMoney(int myMoney, int yourMoney)
        {
            if (myMoney < 0 || yourMoney < 0) throw new ArithmeticException("Our money value is not valid");
            return myMoney + yourMoney;
        }
    }
}
