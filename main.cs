using System;

class Program
{
    public static void Main(string[] args)
    {

        // User Prompt
        
        Console.WriteLine("Enter a number from 1 to 10,000:");
        int number = int.Parse(Console.ReadLine());

        // Possible Outputs
        
        if (isPerfectNumber(number))
        {
            Console.WriteLine("Perfect Number");
        }
        
        else
        {
            Console.WriteLine("Not A Perfect Number");
        }

        
        // Function to check if number is perfect or not

        static bool isPerfectNumber(int num)
        {
            int sum = 0;
            for (int i = 1; i <= num / 2; i++) // Loops through all numbers from 1 to half of the num
            {
              if (num % i == 0) // Check if "i" is a divisor of num
                {
                    sum += i; // Add the divisor to the sum
                 }
            }
            return sum == num; // Returns true if sum equals num
        }
    }
}