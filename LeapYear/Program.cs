using System;

namespace LeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
    
            Program LeapYearChecker = new Program();

            // Takes the users input
            Console.WriteLine("Write a year to check if it's a leap year");
            string input = Console.ReadLine();
            int number = 0;

            // Handles the given input from the user, to check if the input is valid
            try{
                number = int.Parse(input);
            } catch(Exception e) {
                Console.WriteLine("The year needs to be written in numbers!");
                return;
            }

            // Checks if the valid input is a leap year
            Console.WriteLine(LeapYearChecker.isLeapYear(number) ? "yay" : "nay");
        }
        
        // Returns if the given number is a leap year or not in accordance with the Gregorian Calendar.
        bool isLeapYear(int year)
        {
            if (year < 1582)
            {
                throw new ArgumentNullException("The year must be greater then 1582!!");
            }
            else if ((year % 400 == 0) || ((year % 100 != 0) && (year % 4 == 0)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
