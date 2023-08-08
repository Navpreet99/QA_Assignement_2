using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int input = 0;
                int length;
                int width;

                Console.WriteLine("Enter the length of a Circle: ");

                while ((!int.TryParse(Console.ReadLine(), out length)) || length <= 0)
                {
                    Console.WriteLine("Enter value greater than 0: ");
                }

                Console.WriteLine("Enter the width of a Circle: ");

                while ((!int.TryParse(Console.ReadLine(), out width)) || width <= 0)
                {
                    Console.WriteLine("Enter value greater than 0: ");
                }

                do
                {
                    input = Menu();

                    Circle circle = new Circle();

                    circle.GetRadius();
                    circle.SetRadius(length);


                    if (input == 1)
                    {
                        Console.WriteLine("The radius of Circle is: ");
                        Console.WriteLine(circle.GetRadius());
                    }
                    else if (input == 2)
                    {
                        Console.WriteLine("Raius of the Circle: ");
                        while ((!int.TryParse(Console.ReadLine(), out length)) || length <= 0)
                        {
                            Console.WriteLine("Enter the value greater than 0: ");
                        }
                    }
                    else if (input == 3)
                    {
                        Console.WriteLine("The circumference of the Circle is: ");
                        Console.WriteLine(circle.GetCircumference());
                    }
                    else if (input == 4)
                    {
                        Console.WriteLine("Area of the Circle: ");
                        while ((!int.TryParse(Console.ReadLine(), out width)) || width == 0)
                        {
                            Console.WriteLine("Enter the value greater than 0: ");
                        }
                    }
                    else if (input == 5)
                    {
                        Console.WriteLine("Area of the Circle: ");
                        Console.WriteLine(circle.GetArea());
                    }
                    else if (input == 6)
                    {
                        Environment.Exit(0);
                    }
                }
                while (input < 7);
                {
                    Console.WriteLine("Choose proper number");
                    Menu();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static int Menu()
        {
            Console.WriteLine("\nMenu");
            Console.WriteLine("\n 1: Get Circle Radius");
            Console.WriteLine("\n 2: Change Circle Radius");
            Console.WriteLine("\n 3: Get Circumference of the Circle");
            Console.WriteLine("\n 4: Get Circumference of the Circle");
            Console.WriteLine("\n 5: Get Area of the Circle");
            Console.WriteLine("\n 6: Change Circle Width");
            Console.WriteLine("\n 7: Exit");

            return int.Parse(Console.ReadLine());

        }
    }
}