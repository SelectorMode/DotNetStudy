using System;

namespace Inheritance_ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            Boozer seva = new Boozer();
            seva.Name = "Ancle Seva";
            seva.Age = 50;
            seva.Sex = "M";

            seva.SayHello();
            seva.SaySmthNew();
            Program.MyNewNameIs(seva);
          
            Console.ReadKey();

        }

        static void MyNewNameIs(Boozer seva)
        {
            string name = seva.Name;
            int age = seva.Age;
            Console.WriteLine(name + " " + age);
        }

    }

    class Human
    {
        public int Age { get; set; }
        public string Sex { get; set; }
        public string Name { get; set; }

        public void SayHello()
        {
            Console.WriteLine("Hello from Human");
        }
    }

    class Boozer : Human
    {

        public void SaySmthNew()
        {
            Console.WriteLine("Hello from Boozer");
        }
/*
        public static void MyNewNameIs(Boozer seva)
        {
            string name = seva.Name;
            int age = seva.Age;
            Console.WriteLine(name + " " + age);
        }
*/
    }
}
