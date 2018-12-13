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

            // cast seva to Human 
            Human man = seva;
            man.SayHello();

            // cast man back to Boozer
            Boozer boozer = (Boozer)man;

            // check if man is type Boozer if yes then cast to Boozer
            bool isBoozer = man is Boozer;
            if (isBoozer)
            {
                // cast man back to Boozer
                Boozer boozer2 = (Boozer)man;
            }

            // check if man is type Boozer and cast to Boozer
            Boozer asBoozer = man as Boozer;
            if (asBoozer != null)
            {
                asBoozer.SaySmthNew();
            }


            // check if man is type of Boozer and save it in boozer2
            if (man is Boozer boozer4)
            {
                boozer4.SaySmthNew();
            }




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
