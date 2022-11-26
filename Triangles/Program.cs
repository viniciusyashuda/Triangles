﻿using System;

namespace Triangles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float side1, side2, side3;

            Console.Write("Enter the triangle's first side measure:");
            side1 = float.Parse(Console.ReadLine());

            Console.Write("Enter the triangle's second side measure:");
            side2 = float.Parse(Console.ReadLine());

            Console.Write("Enter the triangle's third side measure:");
            side3 = float.Parse(Console.ReadLine());

            if (side1 <= 0 || side2 <= 0 || side3 <= 0)
                Console.WriteLine("The value of a side can not be a negative number or zero");

            else
            {
                if (side1 == side2 && side2 == side3)
                    Console.WriteLine("The triangle is equilateral");

                else if (side1 != side2 && side1 != side3 && side2 != side3)
                    Console.WriteLine("The triangle is scalene");

                else
                    Console.WriteLine("The triangle is isosceles");

            }

            Console.ReadKey();
        }
    }
}
