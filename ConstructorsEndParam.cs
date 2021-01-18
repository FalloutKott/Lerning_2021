using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace property_listning
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleMathStatic simpleMathStatic = new SimpleMathStatic();

            new SimpleMathStatic();
            

            SimpleMath simpleMath = new SimpleMath();

            new SimpleMath(simpleMath.x, simpleMath.y); //вот оно !!! или так !!

            Console.ReadLine();

        }

    }

    class SimpleMath
    {
        public int x;
        public int y;
        public int result;

        public SimpleMath() //constructor default
        {

        }

        public SimpleMath(int x, int y) //constructor
        {
            Console.WriteLine("Введите число х: ");
            this.x = int.Parse(Console.ReadLine()); // this.(обращаемся к полю класса через его конструктор) Если без this. то обращение идёт к аргументам конструктора.
            Console.WriteLine("Введите число y: ");
            this.y = int.Parse(Console.ReadLine()); // this.(обращаемся к полю класса через его конструктор) Если без this. то обращение идёт к аргументам конструктора.
            result = x + y;
            Console.WriteLine($"{x} + {y} = {result}");

            
        }

    }

    class SimpleMathStatic
    {
        static SimpleMathStatic() // static constructor or defult called once
        {
            Console.WriteLine("Hello !!! This is a SimpleMath program");
        }

    }
}
