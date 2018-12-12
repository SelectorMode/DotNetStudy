using System;

namespace GetSet_ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human();

            human.age = 50;
            human.name = "Pedro";

            ShowGetMEthot(human); // transfer data to ShowMethod

        }

        static void ShowGetMEthot(Human human)
        {
            int age = human.age;
            string name = human.name;
            Console.WriteLine(name + " is " + age);
            Console.ReadKey();
        }
    }

    class Human
    {
        public int age;
        public string name;

        private int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value > 0)
                {
                    age = value;
                }
            }
        }
        private string Name
        {
            get
            {
                return name;

            }
            set
            {
                name = value;
            }
        }
    }
}
