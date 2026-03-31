using System;

namespace LabWork1
{
    class Program
    {
        static void Main()
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\n Task 1 - 6 :");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Task1();
                        break;
                    case "2":
                        Task2();
                        break;
                    case "3":
                        Task3();
                        break;
                    case "4":
                        Task4();
                        break;
                    case "5":
                        Task5();
                        break;
                    case "6":
                        Task6();
                        break;
                    case "0":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("wtf");
                        break;
                }
            }
        }

        static void Task1()
        {
            Console.Write(" a1: ");
            string inputA1 = Console.ReadLine();

            Console.Write("d: ");
            string inputD = Console.ReadLine();

            Console.Write("n: ");
            string inputN = Console.ReadLine();

            if (double.TryParse(inputA1, out double a1) &&
                double.TryParse(inputD, out double d) &&
                int.TryParse(inputN, out int n))
            {
                if (n > 0)
                {
                    double sum = ((2 * a1 + d * (n - 1)) / 2.0) * n;
                    Console.WriteLine($" if n =  {n} so: {sum}");
                }
                else
                {
                    Console.WriteLine("n > 0 ");
                }
            }
            else
            {
                Console.WriteLine("only 123457890.");
            }
        }

        static void Task2()
        {
            Console.Write("a: ");
            string inputA = Console.ReadLine();
            Console.Write("b: ");
            string inputB = Console.ReadLine();
            Console.Write("c: ");
            string inputC = Console.ReadLine();

            if (double.TryParse(inputA, out double a) &&
                double.TryParse(inputB, out double b) &&
                double.TryParse(inputC, out double c))
            {
                if (a > 0 && b > 0 && c > 0 && (a + b > c) && (a + c > b) && (b + c > a))
                {
                    if (a == b || a == c || b == c)
                    {
                        Console.WriteLine(" yes ");
                    }
                    else
                    {
                        Console.WriteLine("no ");
                    }
                }
                else
                {
                    Console.WriteLine("plus only");
                }
            }
            else
            {
                Console.WriteLine("only 123457890.");
            }
        }
        static void Task3()
        {
            Console.Write(" x: ");
            string inputX = Console.ReadLine();
            Console.Write(" y: ");
            string inputY = Console.ReadLine();

            if (double.TryParse(inputX, out double x) && double.TryParse(inputY, out double y))
            {
                if (x * x + y * y < 100 && Math.Abs(y) < Math.Abs(x))
                {
                    Console.WriteLine(" yes ");
                }
                else if (x * x + y * y > 100 || Math.Abs(y) > Math.Abs(x))
                {
                    Console.WriteLine("no ");
                }
                else
                {
                    Console.WriteLine("close ");
                }
            }
            else
            {
                Console.WriteLine("only 123457890.");
            }
        }
        static void Task4()
        {
            Console.Write("к - colo, п - rectangle, т - triangle: ");
            string figure = Console.ReadLine().Trim().ToLower();

            switch (figure)
            {
                case "к":
                    Console.Write(" r: ");
                    if (double.TryParse(Console.ReadLine(), out double r) && r > 0)
                    {
                        double perimeter = 2 * Math.PI * r;
                        double area = Math.PI * Math.Pow(r, 2);
                        Console.WriteLine($"Perimetr: {perimeter}");
                        Console.WriteLine($"Plosha: {area}");
                    }
                    else
                    {
                        Console.WriteLine("only 123457890.");
                    }
                    break;

                case "п":
                    Console.Write("a: ");
                    bool isAValid = double.TryParse(Console.ReadLine(), out double rectA);
                    Console.Write(" b: ");
                    bool isBValid = double.TryParse(Console.ReadLine(), out double rectB);

                    if (isAValid && isBValid && rectA > 0 && rectB > 0)
                    {
                        double perimeter = 2 * (rectA + rectB);
                        double area = rectA * rectB;
                        Console.WriteLine($"Perimetr: {perimeter}");
                        Console.WriteLine($"Plosha: {area}");
                    }
                    else
                    {
                        Console.WriteLine("only 123457890.");
                    }
                    break;

                case "т":
                    Console.Write(" a: ");
                    bool isTriAValid = double.TryParse(Console.ReadLine(), out double triA);
                    Console.Write(" b: ");
                    bool isTriBValid = double.TryParse(Console.ReadLine(), out double triB);
                    Console.Write(" c: ");
                    bool isTriCValid = double.TryParse(Console.ReadLine(), out double triC);

                    if (isTriAValid && isTriBValid && isTriCValid &&
                        triA > 0 && triB > 0 && triC > 0 &&
                        (triA + triB > triC) && (triA + triC > triB) && (triB + triC > triA))
                    {
                        double perimeter = triA + triB + triC;
                        double p = perimeter / 2.0;
                        double area = Math.Sqrt(p * (p - triA) * (p - triB) * (p - triC));
                        Console.WriteLine($"perimetr: {perimeter}");
                        Console.WriteLine($"Plosha: {area}");
                    }
                    else
                    {
                        Console.WriteLine("only 123457890.");
                    }
                    break;

                default:
                    Console.WriteLine("idk");
                    break;
            }
        }
                
        static double CubeOfDifference(int a, int b)
        {
            return Math.Pow(a - b, 3);
        }

        static void Task5()
        {
            Console.Write(" a: ");
            string inputA = Console.ReadLine();

            Console.Write("b: ");
            string inputB = Console.ReadLine();

            if (int.TryParse(inputA, out int a) && int.TryParse(inputB, out int b))
            {
                double result = CubeOfDifference(a, b);
                Console.WriteLine($"Cub of  {a} and  {b} equals: {result}");
            }
            else
            {
                Console.WriteLine("only 123457890.");
            }
        }



static void Task6()
        {
            Console.Write(" n: ");
            string inputN = Console.ReadLine();

            Console.Write(" m: ");
            string inputM = Console.ReadLine();

            if (int.TryParse(inputN, out int n) && int.TryParse(inputM, out int m))
            {
                if (m != -1 && n != -1)
                {
                    double numerator = n * n + m + 1.0;
                    double denominator = (m + 1.0) * (n + 1.0);
                    double result = numerator / denominator;

                    Console.WriteLine($"equals : {result}");
                }
                else
                {
                    Console.WriteLine("znamennik ne 0. m and n don`t equals -1.");
                }
            }
            else
            {
                Console.WriteLine("only 123457890.");
            }
        }
    }
}