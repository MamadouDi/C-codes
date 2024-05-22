using System;
using static System.Console;

class CheckDigit
{
    static void Main()
    {
        string user; // Variable to store the user input as a string
        int lastDigit; // Variable to store the last digit of the account number
        int firstThreeDigits; // Variable to store the first three digits of the account number
        
        int divider = 7; // Constant representing the divisor used for validation
        
        // Prompt the user to enter a four-digit account number
        WriteLine("Enter a four digit account number: ");
        
        // Read the user input
        user = ReadLine();
        
        // Extract the first three digits from the user input and convert them to an integer
        firstThreeDigits = Convert.ToInt32(user.Substring(0, 3));
        
        // Extract the last digit from the user input and convert it to an integer
        lastDigit = Convert.ToInt32(user.Substring(3, 1));
        
        // Check if the last digit of the account number matches the remainder when the first three digits are divided by 7
        if (firstThreeDigits % divider == lastDigit)
        {
            // If the condition is true, the account number is considered valid
            WriteLine("The four digit account number is valid");
        }
        else
        {
            // If the condition is false, the account number is considered invalid
            WriteLine("Not Valid");
        }
    }
}