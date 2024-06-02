using System;
/*using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;*/

namespace dcit318_assignment1_10969969
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // GradeDetector();
            // TicketPriceCalc();
            TriangleTypeIdentifier();

           
        }
        static void GradeDetector()
        {
            Console.WriteLine("Hello Bro! Welcome My Grade Detector");
            Console.WriteLine();
            Console.WriteLine("Enter your numerical  grade between 0 and 100");
            Console.WriteLine();

            int value = Convert.ToInt32(Console.ReadLine());

            if (value >= 90)
            {
                Console.WriteLine("Grade A");
            } 
            else if(value >= 80 && value <= 89)
            {
                Console.WriteLine("Grade B");
            }
            else if (value >= 70 && value <= 79)
            {
                Console.WriteLine("Grade C");
            }
            else if (value > 60 && value <= 69)
            {
                Console.WriteLine("Grade D");
            }
            else
            {
                Console.WriteLine("Grade F");
            }
        }
        static void TicketPriceCalc()
        {
            Console.WriteLine("Welcome Bro");
            Console.WriteLine();
            Console.WriteLine("Please enter your age to get your ticket price");

            int age = Convert.ToInt32(Console.ReadLine());

            if(age >= 60 || age <= 12)
            {
                Console.WriteLine("Your ticket price is GHC 7.00");
                Console.WriteLine("Thanks for purchasing a ticket for yourself.");
            }
            else
            {
                Console.WriteLine("Your ticket price is GHC 10.00");
                Console.WriteLine("Thanks for purchasing a ticket for yourself.");
            }
        }
        static void TriangleTypeIdentifier()
        {
            Console.WriteLine("Welcome Bro");
            Console.WriteLine();
            Console.WriteLine("Please enter the length of the sides of the triangle");

            int side1 = Convert.ToInt32(Console.ReadLine());
            int side2 = Convert.ToInt32(Console.ReadLine());
            int side3 = Convert.ToInt32(Console.ReadLine());

            if(side1 == side2 && side2 == side3)
            {
                Console.WriteLine("An Equilateral Triangle");
            }
            else if(side1 == side2 || side2 == side3 || side1 == side3) 
            {
                Console.WriteLine("An Isosceles Triangle");
            }
            else
            {
                Console.WriteLine("A Scalene Triangle");
            }
        }
    }
}
