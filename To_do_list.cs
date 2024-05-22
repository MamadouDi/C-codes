//Mamadou Dia
// 05/08/2024

//Create a console-based application where users can add, edit, and delete tasks.

using System;
using static System.Console;
using System.Collections.Generic;

// Initialize a list to store the tasks
List<string> My_list = new List<string>();
string user;

// Prompt the user to add a task to the list if it is empty
WriteLine("\nYour list is empty. Would you like to add a task to your list (Yes/No)?");
user = ReadLine();

// Loop to allow the user to add tasks as long as they respond "yes"
while (user.ToLower() == "yes")
{
    string task;
    WriteLine("\nPlease add a task: ");
    task = ReadLine();  // Read the task from the user
    My_list.Add(task);  // Add the task to the list
    
    WriteLine("\nWould you like to add another task (Yes/No)? ");
    user = ReadLine();  // Ask if the user wants to add another task
}

// Display all the tasks added to the list
WriteLine("\nTasks added: "); 
foreach (string elements in My_list)
{
    WriteLine(elements);  // Print each task
}

// Prompt the user to confirm if they want to remove the first two tasks
WriteLine("\nThe {0}, and {1} are completed. Do you wish to remove them? (Yes/No)", My_list[0], My_list[1]);
string taskRemove = ReadLine();

// If the user wants to remove the tasks, remove the first two tasks from the list
if (taskRemove.ToLower() == "yes")
{
    My_list.Remove(My_list[0]);  // Remove the first task
    My_list.Remove(My_list[0]);  // Remove the second task (which is now the first after the previous removal)

    // Display the updated list of tasks
    WriteLine("The updated list:");
    foreach (string elements in My_list)
    {
        WriteLine(elements);  // Print each remaining task
    }
}
else 
{
    // If the user does not want to remove the tasks, display the current list of tasks
    foreach (string elements in My_list)
    {
        WriteLine(elements);  // Print each task
    }
}