// Mamadou Dia
// Date: 05/05/2024

// Build a simple game where the computer generates a random number, 
// and the player tries to guess it.

using System;
using static System.Console;

class GuessingGame
{
    static void Main()
    {
        // Initialize the random number generator
        Random rd = new Random();
        
        // Generate a random number between 1 and 100
        int number = rd.Next(1, 101);  // Changed 100 to 101 to include 100 in the range
        int guess = 0;                 // Variable to store the player's guess
        bool replay = true;            // Variable to control the replay loop
        int counting = 0;              // Variable to count the number of attempts
        
        // Game loop
        while (true)
        {
            // Prompt the user to enter their guess
            WriteLine("Please guess a number: ");
            string user = ReadLine();
            guess = Convert.ToInt32(user);
            counting++;
            
            // Check if the guess is within the valid range
            if (guess >= 1 && guess <= 100)
            {
                // Check if the guess is too high
                if (guess > number)
                {
                    WriteLine("Too High! Try again!");
                    WriteLine($"That's your attempt {counting}");
                }
                // Check if the guess is correct
                else if (guess == number)
                {
                    WriteLine("Congratulations! You guessed the correct number!");
                    WriteLine("Would you like to play again? Type 'y' to play again or 'n' to exit.");
                    string playAgain = ReadLine();
                    
                    // Check if the player wants to play again
                    if (playAgain == "n")
                    {
                        replay = false;
                        WriteLine("End Game!");
                        break;
                    }
                    else
                    {
                        // Reset the game variables for a new game
                        number = rd.Next(1, 101);
                        counting = 0;
                    }
                }
                // Check if the guess is too low
                else if (guess < number)
                {
                    WriteLine("Too Low! Try again!");
                    WriteLine($"That's your attempt {counting}");
                }
            }
            // Handle invalid input
            else
            {
                WriteLine("Invalid Input! Please enter a number between 1 and 100.");
            }
        }
    }
}
