using System;

namespace YOpL4
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //Lesson 1.1I1. Полный условный оператор
            double x, y, z;
            int a, b, c;
            //y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("input x");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" ");
            Console.WriteLine("input z");
            z = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" ");
            Console.WriteLine("input a");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ");
            Console.WriteLine("input b");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ");
            Console.WriteLine("input c");
            c = Convert.ToInt32(Console.ReadLine());


            if (x>0)
            {
                y = Math.Sin(x);
                Console.WriteLine(" ");
                Console.WriteLine($"Sin x = {y}");
            }
            else
            {
                y = Math.Cos(x);
                Console.WriteLine(" ");
                Console.WriteLine($"Cos x = {y}");
            }
            //Lesson 1.2

            if (x > z)
            {
                Console.WriteLine(" ");
                Console.WriteLine("x > z");

            }
            else if (x < z)
            {
                Console.WriteLine(" ");
                Console.WriteLine("x < z");

            }
            else if (x == z)
            {
                Console.WriteLine(" ");
                Console.WriteLine("x = z");

            }
            else 
            {
                Console.WriteLine(" ");
                Console.WriteLine("error");
            }

            //Lesson 1.1 I3. Использование сложных условий 

            if (-5 < a & a < 3)
            {
                Console.WriteLine(" ");
                Console.WriteLine($"{a} is middle -5 & 3");
            }
            else
            {
                Console.WriteLine(" ");
                Console.WriteLine($"{a} is not middle -5 & 3");
            }

            if (a<b&b<c)
            {
                Console.WriteLine(" ");
                Console.WriteLine($"{a}<{b}<{c}");
            }
            else if (a > b & b > c)
            {
                Console.WriteLine(" ");
                Console.WriteLine($"{a}<{b}<{c}");
            }
            else
            {
                Console.WriteLine(" ");
                Console.WriteLine($"{a},{b},{c} do not meet the conditions  ");
            }
            //Lesson1.2
            if (a%b==0 | b%a==0)
            {
                Console.WriteLine("Yes, one of the numbers is a divisor of the other  ");
            }
            else
            {
                Console.WriteLine(" ");
                Console.WriteLine("No, none of the numbers are divisors of the other. ");
            }

            //Lesson С1. Вывод данных по формату
            Console.WriteLine(" ");


        }
    }
}
