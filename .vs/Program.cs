using System;

namespace Task1_vyrobnycha
{
    class Program
    {
        static void Main(string[] args)
        {
            Task_1();
            Task_2();
            Task_3();
        }

        static void Task_1()
        {
            Console.Write("Enter natural number to Check Palindrome: ");
            string number = Console.ReadLine();
            string reverse = "";

            for (int i = 0; i < number.Length; ++i)
            {
                reverse += number[number.Length - 1 - i];
            }

            if (number == reverse)
            {
                Console.WriteLine($"{number} is Palindrome.\n");
            }
            else
            {
                Console.WriteLine($"{number} is not Palindrome.\n");
            }
        }

        static void Task_2()
        {
            Console.Write("Enter x: ");
            double x = double.Parse(Console.ReadLine());

            Console.Write("Enter y: ");
            double y = double.Parse(Console.ReadLine());

            Console.Write("Enter z: ");
            double z = double.Parse(Console.ReadLine());
            
            double x_z = x * z;
            double p = Math.PI / 5 + Math.Pow(y, 3);
            double a = Math.Pow(x_z, 2) / 1 + Math.Pow(x_z, 4) / 1 * 2 * 3 + Math.Pow(x_z, 6) / 1 * 2 * 3 * 4 * 5;
            double b = Math.Pow(Math.Cos(p), 2) - 2 * Math.Sin(p);
            double c = Math.Sqrt(x * x + y * y + z * z);
            double min = Math.Pow(Math.Min(Math.Min(a * a, b), c * c * c), 3);
            Console.WriteLine($"Answer is: {min}\n");
        }

        static void Task_3()
        {
            int[,] B = new int[5, 7];
            Random rand = new Random();
            Console.WriteLine("Matrix B: ");
            for (int i = 0; i < 5; ++i)
            {
                for (int j = 0; j < 7; ++j)
                {
                    B[i, j] = rand.Next(0, 10);
                    Console.Write(B[i, j] + " ");
                }
                Console.WriteLine();
            }

            int[] c = new int[B.GetLength(0)];
            for (int i = 0; i < B.GetLength(0); ++i)
            {
                int even_count = 0;
                for (int j = 0; j < B.GetLength(1); ++j)
                {
                    if (B[i, j] % 2 == 0)
                    {
                        even_count++;
                    }
                }
                c[i] = even_count;
            }

            Console.Write("\nVector c: [ ");
            for(int i = 0; i < c.Length; ++i)
            {
                Console.Write(c[i] + " ");
            }
            Console.Write("]\n");

            int maxElement = c[0];
            int maxIndex = 0;
            for (int i = 1; i < c.Length; ++i)
            {
                if (c[i] > maxElement)
                {
                    maxElement = c[i];
                    maxIndex = i;
                }
            }
            Console.WriteLine($"The maximum element of the vector c: {maxElement}");
            Console.WriteLine($"The number of the maximum element of the vector c: {maxIndex}");
        }
    }
}
