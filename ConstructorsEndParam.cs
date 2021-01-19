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
            
            new SimpleMathStaticMsg();
            
            SimpleMath simpleMath = new SimpleMath();

            new SimpleMath(simpleMath.x, simpleMath.y); //вот оно 

            Console.ReadLine();

        }

    }

    class SimpleMath
    {
        public int x;
        public int y;
        public int result;
        public string HelloMsg = "Hello !!! This is a SimpleMath program";

        public SimpleMath() //constructor default
        {

        }

        public SimpleMath(int x, int y) //constructor
        {
            Console.Write("Введите число х: ");
            this.x = x;                        // this.(обращаемся к полю класса через его конструктор) Если без this. то обращение идёт к аргументам конструктора.
            x = int.Parse(Console.ReadLine()); 
            Console.Write("Введите число y: ");
            this.y = y;                        // this.(обращаемся к полю класса через его конструктор) Если без this. то обращение идёт к аргументам конструктора.
            y = int.Parse(Console.ReadLine()); 
            result = x + y;
            Console.WriteLine($"{x} + {y} = {result}");

        }

    }

    class SimpleMathStaticMsg
    {
        static SimpleMathStaticMsg() // static constructor or defult called once
        {
            SimpleMath simpleMath = new SimpleMath();
            Console.WriteLine(simpleMath.HelloMsg);
        }

        

    }
}
