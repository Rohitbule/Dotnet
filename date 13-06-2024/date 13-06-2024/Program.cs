using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace date_13_06_2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of nights stayed: ");
            int numberOfNights = int.Parse(Console.ReadLine());

            // Prompt user for rate per night
            Console.Write("Enter the rate per night: ");
            decimal ratePerNight = decimal.Parse(Console.ReadLine());


            Console.Write("Enter additional charges (e.g., room service, mini-bar): ");
            decimal additionalCharges = decimal.Parse(Console.ReadLine());
            string gstNumber = "GST1234ABCD5678";

            decimal totalRoomCost = numberOfNights * ratePerNight;
            decimal totalBill = totalRoomCost + additionalCharges;

            Console.WriteLine("\nHotel Name is : RAj Kamal");
            Console.WriteLine("\nHotel Bill Summary");
            Console.WriteLine("Description        \t\t", "Amount");
            

            Console.WriteLine("Number of nights:  \t\t" + numberOfNights);
            Console.WriteLine("Rate per night:   \t\t" + ratePerNight);
            Console.WriteLine("Total room cost:   \t\t" + totalRoomCost);
            Console.WriteLine("Additional charges:\t\t" + additionalCharges);
            Console.WriteLine("GST Number:        \t\t" + gstNumber);
            Console.WriteLine("Total bill:        \t\t" + totalBill);
            Console.ReadLine();

        }
    }
}
