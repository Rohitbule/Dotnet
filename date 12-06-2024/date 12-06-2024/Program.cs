using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace date_12_06_2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int a = 10;
            //int b = 20;
            //int c = a + b;
            //Console.WriteLine($"the addition of {a} and {b} is " +c);

            //taking input form user .
            /*Console.Write("the first number is :");
            int a=Convert.ToInt32(Console.ReadLine());
            Console.Write("the first number is :");
            int b=Convert.ToInt32(Console.ReadLine());
            int c = a + b;  
            Console.WriteLine($"the addition of {a} and {b} :"+c);
            Console.ReadLine();*/

            //AREA OF CIRCLE
            /*int r = 15;
            float a = area(r);
            Console.WriteLine("Area of circle is: " + a);
            Console.ReadLine();

            float area(int radius)
            {
               float c = 3.14f * radius * radius;
               return c;
            }*/

            //AREA OF RECTANGLE
            /*Console.Write("enter the length of rectangle:");
            int length =Convert.ToInt32(Console.ReadLine());
            Console.Write("enter the breadth of rectangle : ");
            int breadth = Convert.ToInt32(Console.ReadLine());
            int a = area(length, breadth);
            Console.WriteLine("Area of rectangle is :"+a);
            Console.ReadLine();

            int area(int l , int b)
            {
                int c = l * b;
                return c;
            }*/

            //area of triangle
            /*Console.Write("enter the length of triangle : ");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the height of triangle : ");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter the breadth of rectangle : ");
            int breadth = Convert.ToInt32(Console.ReadLine());
            int t = triangle( length, height, breadth);
            Console.WriteLine("the area of triangle is " + t);
            Console.ReadLine();

            int triangle(int l,int b,int h)
            {
                int g = l * b * h;
                return g;
            }*/

            //AREA OF POLYGAON
            /*Console.Write("Enter the perimeter of polygaon");
            int perimeter = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the apothem of polygaon");
            int apothem = Convert.ToInt32(Console.ReadLine());
            int area = polygaon(perimeter, apothem);
            Console.WriteLine("The area of polygaon is " +area);
            Console.ReadLine();

            int polygaon(int p , int a)
            {
                int c = (p / 2) * a;
                return c;
            }*/

            /*//PROGRAM TO DISPLAY DATE AND TIME OF LOCAL SYSTEM
            Console.WriteLine("Program to display date and local time");
            // Get the current date and time
            DateTime now = DateTime.Now;
            Console.WriteLine("Current Date and Time : " + now);
            Console.ReadLine();*/

            //write a program to print statement of records srno, name,branch,sem,college
            /*Console.WriteLine("How many records do you want to insert?");
            int n = int.Parse(Console.ReadLine());

            string[] name = new string[n];
            string[] branch = new string[n];
            string[] sem = new string[n];
            string[] college = new string[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter details for student {i + 1}:");

                Console.Write("Name: ");
                name[i] = Console.ReadLine();

                Console.Write("Branch: ");
                branch[i] = Console.ReadLine();

                Console.Write("Semester: ");
                sem[i] = Console.ReadLine();

                Console.Write("College: ");
                college[i] = Console.ReadLine();
            }

            Console.WriteLine("\nStudents' records");
            Console.WriteLine("Sr.No\t\tName\t\tBranch\t\tSem\t\tCollege");

            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine($"{i + 1}\t\t{name[i]}\t\t{branch[i]}\t\t{sem[i]}\t\t{college[i]}");
            }
            Console.ReadLine();*/



        }
    }
}
