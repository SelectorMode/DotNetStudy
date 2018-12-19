using System;

namespace Constructors_ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Constructors constructorsDefault = new Constructors();
            Constructors constructorsOverloaded = new Constructors(2, 3);
            Constructors constructorsInherited = new Constructors("giveMeScore");

            Console.WriteLine("x = {0}; y = {1}", constructorsDefault.getX, constructorsDefault.getY);

            Console.WriteLine(new string('-', 25));

            Console.WriteLine("x = {0}; y = {1}", constructorsOverloaded.getX, constructorsOverloaded.getY);

            Console.WriteLine(new string('-', 25));

            Console.WriteLine("x = {0}; y = {1}", constructorsInherited.getX, constructorsInherited.getY);


            //MyClass instance = new MyClass();
            //instance.SetName = "myInstance";
            //Console.WriteLine("{0}", instance.SetName);

            Console.ReadKey(); //delay
        }
    }

    class Constructors
    {   //fields
        private int x, y;
        private string name;

        //propetrties
        public int getX
        {
            get
            {
                return x;
            }
        }
        public int getY
        {
            get
            {
                return y;
            }
        }

        public Constructors()
        {

        }

        public Constructors(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public Constructors(string name) : this(100, 200)
        {
            this.name = name;
        }

    }


    //class MyClass
    //{
    //    private string field;

    //    public string SetName
    //    {
    //        get
    //        {
    //            return field;
    //        }
    //        set
    //        {
    //            field = value;
    //        }
    //    }
    //}
}
