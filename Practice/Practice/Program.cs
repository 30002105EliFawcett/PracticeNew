using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            Console.WriteLine("Hamiora Taurima");

            int add = 74;
            int add2 = 36;
            int add3 = add + add2;
            Console.WriteLine(add3);

            int divide = 50;
            int divide2 = 3;
            int divide3 = divide / divide2;
            Console.WriteLine(divide3);

            int input = 0;
            int input2 = 0;
            int input3 = input * input2;

            Console.WriteLine("Input First Number");
            input = int.Parse(Console.ReadLine());
            Console.WriteLine("Input Second Number");
            input2 = int.Parse(Console.ReadLine());
            Console.WriteLine(input3);

            int i, num;
            Console.WriteLine("Input A Number");
            num=int.Parse(Console.ReadLine());

            for (i= 0; i < 11; i++)
            {
                Console.WriteLine(" {0} X {1} = {2} ", num, i, num * i);
            }
            double radius;
            double perimeter;
            double area;
            Console.WriteLine("Input a Number to calculate the area and perimeter of a circle");
            radius=int.Parse(Console.ReadLine());

            perimeter = 2 * 3.14159265359 * radius;
            area = 3.14159265359 * (radius * 2);

            Console.WriteLine(perimeter);
            Console.WriteLine(area);
        }
        
    }
}
