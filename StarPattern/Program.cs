using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StarPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example1();
            // Example2();
            // Example3();
            // Example4();
            // Example5();
            // Example6();
            // Example7();
            // Example8();
             Example9();
        }

        public static void Example1()
        {
            int x, y, z;
            for (x = 6; x >= 1; x--)
            {
                for (y = 1; y < x; y++)
                {
                    Console.Write(" ");
                }
                for (z = 6; z >= x; z--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }

        public static void Example2()
        {
            int x, y;
            for (x = 1; x <= 6; x++)
            {
                for (y = 1; y <= x; y++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }

        public static void Example3()
        {
            int x, y;
            for (x = 5; x >= 1; x--)
            {
                for (y = 1; y <= x; y++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }

        public static void Example4()
        {
            int x, y, z;
            for (x = 5; x >= 1; x--)
            {
                for (y = 5; y > x; y--)
                {
                    Console.Write(" ");
                }
                for (z = 1; z <= x; z++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }

        public static void Example5()
        {
            int x, y, z;
            for (x = 1; x <= 5; x++)
            {
                for (y = x; y < 5; y++)
                {
                    Console.Write(" ");
                }
                for (z = 1; z < (x * 2); z++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }

        public static void Example6()
        {
            int x, y, z;
            for (x = 5; x >= 1; x--)
            {
                for (y = 5; y > x; y--)
                {
                    Console.Write(" ");
                }
                for (z = 1; z < (x * 2); z++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }

        public static void Example7()
        {
            int x, y;
            for (x = 1; x <= 5; x++)
            {
                for (y = x; y < 5; y++)
                {
                    Console.Write(" ");
                }
                for (y = 1; y <= (2 * x - 1); y++)
                {
                    if (x == 5 || y == 1 || y == (2 * x - 1))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }

        public static void Example8()
        {
            int x, y;
            for (x = 1; x <= 5; x++)
            {
                for (y = 1; y <= 5; y++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }

        public static void Example9()
        {
            int x, y;
            for (x = 1; x <= 5; x++)
            {
                for (y = 1; y <= x; y++)
                {
                    if (y == 1 || y == x || x == 5)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}