using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project4_operator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*//LOGICAL OPERATOR
            bool a = true;
            bool b = false;
            // AND operation
            bool andResult = a && b;
            Console.WriteLine("a && b = {andResult}"); // Output: a && b = False
            // OR operation
            bool orResult = a || b;
            Console.WriteLine($"a || b = {orResult}"); // Output: a || b = True
            // NOT operation
            bool notResult = !a;
            Console.WriteLine($"!a = {notResult}"); // Output: !a = False
            // XOR operation
            bool xorResult = a ^ b;
            Console.WriteLine($"a ^ b = {xorResult}"); // Output: a ^ b = True
            // Combining logical operations
            bool combinedResult = (a && b) || (!a && !b);
            Console.WriteLine($"(a && b) || (!a && !b) = {combinedResult}"); // Output: (a && b) || (!a && !b) = False
            Console.ReadLine();*/

            //Relational operator
            /*int a = 10;
            int b = 20;
            Console.WriteLine("a == b: " + (a == b));  // False
            Console.WriteLine("a != b: " + (a != b));  // True
            Console.WriteLine("a > b: " +a );    // False
            Console.WriteLine("a < b: " + (a < b));    // True
            Console.WriteLine("a >= b: " + (a >= b));  // False
            Console.WriteLine("a <= b: " + (a <= b));  // True

            string str1 = "hello";
            string str2 = "world";
            Console.WriteLine("str1 == str2: " + (str1 == str2));  // False
            Console.WriteLine("str1 != str2: " + (str1 != str2));  // True
            Console.ReadLine();*/

            // Prompt the user to enter the student's score
            Console.WriteLine("Enter the student's score (0-100):");
            string input = Console.ReadLine();

            // Convert the input to an integer
            if (int.TryParse(input, out int score))
            {
                // Validate the score is within the acceptable range
                if (score >= 0 && score <= 100)
                {
                    // Determine the grade using relational operators
                    string grade = GetGrade(score);

                    // Output the grade
                    Console.WriteLine($"The grade is: {grade}");
                }
                else
                {
                    Console.WriteLine("Error: The score must be between 0 and 100.");
                }
            }
            else
            {
                Console.WriteLine("Error: Invalid input. Please enter a numeric value.");
            }
            Console.ReadLine();
        }

        // Method to determine the grade based on the score
        static string GetGrade(int score)
        {
            if (score >= 90)
            {
                return "A";
            }
            else if (score >= 80)
            {
                return "B";
            }
            else if (score >= 70)
            {
                return "C";
            }
            else if (score >= 60)
            {
                return "D";
            }
            else
            {
                return "F";
            }
        } 
        
    }
}
