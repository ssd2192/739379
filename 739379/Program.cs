using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _739379
{
    class Program
    {
       static Random rand = new Random();
        static void Main(string[] args)
        {
            Manager m1 = new Manager();
            m1.Run();
            TaskTwo tt = new TaskTwo();
            tt.MutiTable();
            tt.Sum();
            tt.Swap();
            tt.Multiply();

            while (true)
            {
                for (; Orange();)
                {

                }
            }
        }

        public static bool Orange()
        {
            int counter = 0;
            Console.WriteLine("I am in Orange for {0}: ", counter);
            
            int r = rand.Next(1, 100);
            if (r > 50)
            {
                return true;
            }
            else

            return false;
            
        }


    }

    class TaskTwo
    {
        public void NamePrint()
        {
            string name;
            Console.Write("Enter Your Name ");
            name = Console.ReadLine();
            Console.WriteLine("Hello {0}", name);
            Console.ReadKey();
        }
        public void Sum()
        {
            int a, b, sum = 0;
            Console.WriteLine("Enter first number");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second number");
            b = Convert.ToInt32(Console.ReadLine());
            sum = a + b;
            Console.WriteLine("The Sum is {0}", sum);

            Console.ReadKey();
        }

        public void Swap()
        {
            int a, b, temp =0 ;
            Console.WriteLine("Enter first number");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second number");
            b = Convert.ToInt32(Console.ReadLine());

            temp = a;
            a = b;
            b = temp;

            Console.WriteLine("Swapped numebrs a is {0}, b is {1} ", a, b);
        }

        public void Multiply()
        {
            int a, b, c, multi = 0;
            Console.WriteLine("Enter first number");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second number");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Third number");
            c = Convert.ToInt32(Console.ReadLine());
            multi = a * b * c;
            Console.WriteLine("The Sum is {0}", multi);

            Console.ReadKey();
        }

        public void MutiTable()
        {
            int a;
            Console.WriteLine("Enter number");
            a = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < 10; i++)
            {
                System.Console.WriteLine("{0} x {1} is {2}", a,i+1, a*(i+1));
            }
            Console.ReadKey();
        }

        
    }

    class Manager
    {
        public void Run()
        {

        }
    }
    class Dog
    {
        static int dogVar1=0;
        string dogName;
        Random rand = new Random();

        public int SetStrength()
        {
            int strength = 0;

            //for (; ; )
            //{

            //}

            return rand.Next(1,100);
            
        }
        

    }

    class Cat
    {
        static int catVar1=0;
        string catName;
        public void catMethod()
        {
            for (; ; )
            {

            }
        }
    }
}
