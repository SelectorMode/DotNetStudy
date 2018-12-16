using System;

namespace PolyMorph_ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = new Animal[2];

            Dog dog = new Dog();
            dog.Name = "Sharik";

            Boozer boozer = new Boozer();
            boozer.Name = "Zloebuch";

            animals[0] = dog;
            animals[1] = boozer;

            for (int i = 0; i < animals.Length; i++)
            {
                Console.WriteLine(animals[i] + " says: ");
                animals[i].GetRoar();
            }

            Test test = new Test();
            test.ShowContent();

            Console.ReadKey();
        }
    }

    class Animal
    {
        public string Name { get; set; }

        public virtual void GetRoar()
        {
            Console.WriteLine("Abstrakt Roar");
        }
    }

    class Dog : Animal
    {// ovveride of the method
        public override void GetRoar()
        {
            Console.WriteLine("Bow-wow");
            base.GetRoar(); // refers to base class method: "Abstrakt Roar"
        }
    }

    class Boozer : Animal
    {// ovveride of the method
        public override void GetRoar()
        {
            Console.WriteLine("What have you done since yesterday?");
        }
    }
    class Test
        
    {
        int a = 2;

        public void ShowContent()
        {
            int a = 3;
            Console.WriteLine(a);
            Console.WriteLine(this.a);
            Console.ReadKey();
        }

    }
}
