using System;
using System.Text;

namespace String_ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            string sampleStr1 = "someString";
            string sampleStr2 = "somestring";
            string sampleStr3 = "";
            string sampleStr4 = string.Empty;
            string fullName = "Khomenko,Sergey";


            if (sampleStr1.Equals(sampleStr2, StringComparison.CurrentCultureIgnoreCase))
            {                
                for (int i = 0; i < sampleStr1.Length && i < sampleStr2.Length; i++)
                {
                    
                    Console.WriteLine(i + " is " + sampleStr1[i] + " and " + sampleStr2[i]);
                }
                Console.WriteLine("Equals except cases");

                string[] splitName = fullName.Split(',');
                string joinedName = String.Join(";", splitName);

                Console.WriteLine(joinedName);
                Console.WriteLine(splitName[1] +" "+ splitName[0]);

            }
            Console.ReadKey();

        }
    }
}
