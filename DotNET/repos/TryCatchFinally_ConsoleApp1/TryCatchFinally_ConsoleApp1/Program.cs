using System;
using System.IO;


namespace TryCatchFinally_ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = { "line_1;", "line_2;", "line_3;" };

            //using (System.IO.StreamWriter writer = new System.IO.StreamWriter(@"D:\DotNetStudy\DotNET\repos\!FILES\TextFile.txt"))
            //{
            //    foreach (var line in lines)
            //    {
            //        writer.WriteLine(line);

            //    }
            //    writer.Dispose();
            //}  
            StreamWriter writer = null;
            try
            {
                writer = new System.IO.StreamWriter(@"D:\DotNetStudy\DotNET\repos\!FILES\TextFile.txt");
                foreach (var line in lines)
                {
                    writer.WriteLine(line);

                }
            }
            catch (IOException excpn1)
            {
                Console.WriteLine(excpn1.Message);
                Console.ReadKey();
            }
            finally
            {
                if (writer != null)
                {
                    writer.Dispose();
                    Console.WriteLine("Disposed!");
                    Console.ReadKey();
                }
            }


        }
    }
}


