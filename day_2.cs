using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задание 1 
            Console.WriteLine("Задание 1");
            Console.WriteLine("enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num < 0)
            {
                Console.WriteLine(num + 5);
            }
            else if (num > 0)
            {
                Console.WriteLine(num - 5);
            }
            else
            {
                Console.WriteLine("reply: " + "Error");
            }

            //Задание 2
            Console.WriteLine("\n" + "Задание 2");
            Console.WriteLine("enter the first number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the second number");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the third number");
            int c = Convert.ToInt32(Console.ReadLine());
            if (a > b && a > c)
            {
                Console.WriteLine("reply: " + a);
            }
            else if (b > a && b > c)
            {
                Console.WriteLine("reply: " + b);
            }
            else if (c > a && c > b)
            {
                Console.WriteLine("reply: " + c);
            }

            //Задание 3
            Console.WriteLine("\n" + "Задание 3");
            Console.WriteLine("enter the first number");
            int result = 0;
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the second number");
            int e = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the third number");
            int f = Convert.ToInt32(Console.ReadLine());
            if (d > 0)
            {
                result += d;
            }
            if (e > 0)
            {
                result += e;
            }
            if (f > 0)
            {
                result += f;
            }
            Console.WriteLine("reply: " + result);

            //Задание 4
            Console.WriteLine("\n" + "Задание 4");
            Console.WriteLine("enter the number");
            int res = 0;
            int x = Convert.ToInt32(Console.ReadLine());
            if (x > 10)
            {
                res = x *= 2;
            }
            else if (x < 10)
            {
                res = x;
            }
            Console.WriteLine("reply: " + res);

            //Задание 5
            Console.WriteLine("\n" + "Задание 5");
            Console.WriteLine("enter the number in the range from 1 to 7");
            int g = Convert.ToInt32(Console.ReadLine());
            switch (g)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
            }
            //Задание 6
            Console.WriteLine("\n" + "Задание 6");
            for (int i = 200; i < 500; i++)
            {
                if (i % 17 == 0)
                {
                    Console.WriteLine("reply: " + i);
                    break;
                }
            }
            //Задание 7
            Console.WriteLine("\n" + "Задание 7 ");
            double dis = 10;
            double percent = 0.05;
            double totaldis = dis;
            int day = 1;
            while (dis < 20)
            {
                dis += dis * percent;
                day++;
            }
            Console.WriteLine($"a person will run 20km on the {day} day");

            dis = 10;
            day = 1;
            while (totaldis < 100)
            {
                dis += dis * percent;
                totaldis += dis;
                day++;
            }
            Console.WriteLine($"the amount of mileage will be more then 100km on the {day} day");

            //Задание 8
            Console.WriteLine("\n" + "Задание 8 ");
            int factorial = Convert.ToInt32(Console.ReadLine());
            int chislo = 1;
            for (int i = 1; factorial >= i; i++)
            {
                chislo *= i;
                Console.WriteLine("reply: " + chislo);
            }

            //Задание 9
            Console.WriteLine("\n" + "Задание 9 ");
            int natnum = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; natnum >= i; i++)
            {
                if (natnum % i == 0)
                {
                    Console.WriteLine("reply: " + i);
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}

        






