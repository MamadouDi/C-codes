using System;
using static System.Console;

class makesAndModels
{
    static void Main()
    {
        // Arrays to store the makes and models of the cars
        String[] makes =
        {
            "Bugatti", "Bugatti", "Lamborghini", "Lamborghini", "Lamborghini", "Land Rover", "Land Rover", "Land Rover",
            "Land Rover", "Lotus"
        };

        String[] models =
        {
            "Chiron", "Divo", "Huracan", "Urus", "Aventador Coupe", "Evoque", "Range Rover", "Discovery",
            "Defender 110", "Evora"
        };

        // Arrays to store the city and highway miles per gallon for each car
        double[] cityMpg = { 10.4, 10.4, 16, 15, 10.7504, 25.1326, 20.4, 19.7, 20.6902, 19.5649 };
        double[] hwyMpg = { 18.2, 17.7, 24.1422, 22.8, 19.6744, 38.265, 29.3, 28.6, 29.4554, 32.994 };

        // Constants for fuel cost, annual mileage, and driving percentages
        double fuelCostPerGallon = 3.50;
        double annualMileage = 12000.00;
        double cityDrivingPct = 0.3;
        double highwayDrivingPct = 0.7;

        // Array to store the total annual fuel costs for each car
        double[] totalAnnualFuelCosts = new double[cityMpg.Length];

        // Calculate the annual fuel costs for each car
        for (int i = 0; i < cityMpg.Length; i++)
        {
            // Calculate the city and highway annual fuel costs
            double cityAnnualFuelCost = (annualMileage * cityDrivingPct / cityMpg[i]) * fuelCostPerGallon;
            double highwayAnnualFuelCost = (annualMileage * highwayDrivingPct / hwyMpg[i]) * fuelCostPerGallon;
            
            // Store the total annual fuel cost
            totalAnnualFuelCosts[i] = cityAnnualFuelCost + highwayAnnualFuelCost;

            // Output the costs for each car
            WriteLine($"\nThe City annual fuel cost for {makes[i]} {models[i]} is {cityAnnualFuelCost:F2}");
            WriteLine($"The highway annual fuel cost for {makes[i]} {models[i]} is {highwayAnnualFuelCost:F2}");
            WriteLine($"The Total annual fuel cost for {makes[i]} {models[i]} is {totalAnnualFuelCosts[i]:F2}");
        }

        // Initialize the highest and lowest annual costs with the first element
        double highestAnnualCost = totalAnnualFuelCosts[0];
        double lowestAnnualCost = totalAnnualFuelCosts[0];
        int highestAnnualCostIndex = 0;
        int lowestAnnualCostIndex = 0;
        
        // Initialize the sum of total fuel costs with the first element
        double sumOfTotalFuelCosts = totalAnnualFuelCosts[0];

        // Loop through the remaining elements to find the highest, lowest, and total costs
        for (int i = 1; i < totalAnnualFuelCosts.Length; i++)
        {
            // Check if the current cost is higher than the highest recorded cost
            if (totalAnnualFuelCosts[i] > highestAnnualCost)
            {
                highestAnnualCost = totalAnnualFuelCosts[i];
                highestAnnualCostIndex = i;
            }

            // Check if the current cost is lower than the lowest recorded cost
            if (totalAnnualFuelCosts[i] < lowestAnnualCost)
            {
                lowestAnnualCost = totalAnnualFuelCosts[i];
                lowestAnnualCostIndex = i;
            }

            // Add the current cost to the sum of total fuel costs
            sumOfTotalFuelCosts += totalAnnualFuelCosts[i];
        }

        // Output the car with the highest and lowest annual fuel costs
        WriteLine($"\nThe car with the highest annual fuel cost is {makes[highestAnnualCostIndex]} {models[highestAnnualCostIndex]} with a cost of {highestAnnualCost:F2}");
        WriteLine($"The car with the lowest annual fuel cost is {makes[lowestAnnualCostIndex]} {models[lowestAnnualCostIndex]} with a cost of {lowestAnnualCost:F2}");
        
        // Calculate and output the average annual fuel cost
        double average = sumOfTotalFuelCosts / totalAnnualFuelCosts.Length;
        WriteLine($"\nThe average annual fuel cost for all vehicles is {average:F2}");
    }
}
