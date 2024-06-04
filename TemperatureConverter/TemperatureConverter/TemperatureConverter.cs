// Mamadou Dia
//05/04/2024

//Program: Develop a program that converts temperature
//between Fahrenheit and Celsius. 

using System;
using static System.Console;

class TemperatureConverter
{
    static void Main()
    {
        string USER; // Create a user variable to store a value to the temperature
        string OPTION; // create an option variable to choose how to convert the temperature 
        double VALUE; // Assign a value variable to convert the user from a string to integer
        double TEMPERATURE; // the converted temperature either F or C
        
        
        WriteLine("\nWelcome to the temperature converter!");
        
        // Assign a value to the temperature. 
        WriteLine("Please enter a temperature value");
        USER = ReadLine();
        
        // Convert user to int
        VALUE = Convert.ToDouble(USER);
        
        // Ask the user to choose an option to convert the temperature.
        // Either from Celsius to fahrenheit, or from fahrenheit to Celsius
        
        WriteLine("\nHow do you want to convert your temperature?");
        
        WriteLine("Option 'A': From Celsius to Fahrenheit \nOption 'B': From Fahrenheit to Celcius");
        OPTION = ReadLine();

        
        if (OPTION == "A" || OPTION == "a") // Convert from Celsius to Fahrenheit if user choose option A
        // with the formula: 9/5 x C + 32 with C representing the value of the temperature.
        { 
            TEMPERATURE = (9 * VALUE)/5 + 32;
            WriteLine("{0} is the result from converting {1} to Fahrenheit", TEMPERATURE + "°F", VALUE+"°C");
        }

        if (OPTION == "B" || OPTION == "b") // Convert from Fahrenheit to Celsius if user choose option B
        // with the formula 5/9 x (F - 32) 
        {
            TEMPERATURE = ((VALUE - 32) * 5) / 9;
            WriteLine("{0} is the result from converting {1} to Celsius", TEMPERATURE+"°C", VALUE+"°F");
        }
    }
}