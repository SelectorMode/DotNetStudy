using System;

namespace Nullable_ConsoleApp1
{
    class Program
    {

        static void Main()
        {

            int? count = null;

            if (count.HasValue)

                Console.WriteLine("count has this value: " + count.Value);

            else

                Console.WriteLine("count has no value");

            // will print "count has no value"

            count = 100;

            if (count.HasValue)

                Console.WriteLine("count has this value: " + count.Value);

            else

                Console.WriteLine("count has no value");

            // will print "count has this value: 100"
            Console.ReadKey();
        }

    }
}

