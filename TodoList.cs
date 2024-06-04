using System;
using System.Collections.Generic;

namespace ToDoList
{
    class Program
    {
        // Define a class to represent a task
        class Task
        {
            public string Description { get; set; }
            public bool Done { get; set; }

            public Task(string description, bool done)
            {
                Description = description;
                Done = done;
            }
        }

        // Define a list to store the tasks
        static List<Task> tasks = new List<Task>();

        static void Main(string[] args)
        {
            // Display a welcome message
            Console.WriteLine("Welcome to the To Do List app!");
            Console.WriteLine("You can add, edit, delete, and mark tasks as done.");
            Console.WriteLine("Type 'help' to see the available commands.");

            // Start the main loop
            while (true)
            {
                // Prompt the user for a command
                Console.Write("> ");
                string command = Console.ReadLine().ToLower();
                Console.Clear();

                // Execute the command
                switch (command)
                {
                    case "help":
                        ShowHelp();
                        break;
                    case "add":
                        AddTask();
                        break;
                    case "edit":
                        EditTask();
                        break;
                    case "delete":
                        DeleteTask();
                        break;
                    case "done":
                        MarkTaskAsDone();
                        break;
                    case "list":
                        ListTasks();
                        break;
                    case "exit":
                        Exit();
                        break;
                    default:
                        Console.WriteLine("Invalid command. Type 'help' to see the available commands.");
                        break;
                }
            }
        }

        // A method to show the help message
        static void ShowHelp()
        {
            Console.WriteLine("The available commands are:");
            Console.WriteLine("help - show this help message");
            Console.WriteLine("add - add a new task");
            Console.WriteLine("edit - edit an existing task");
            Console.WriteLine("delete - delete an existing task");
            Console.WriteLine("done - mark an existing task as done");
            Console.WriteLine("list - list all the tasks");
            Console.WriteLine("exit - exit the program");
        }

        // A method to add a new task
        static void AddTask()
        {
            // Prompt the user for a task description
            Console.Write("Enter the task description: ");
            string description = Console.ReadLine();

            // Create a new task object
            Task task = new Task(description, false);

            // Add the task to the list
            tasks.Add(task);

            // Display a confirmation message
            Console.WriteLine("Task added successfully.");
        }

        // A method to edit an existing task
        static void EditTask()
        {
            // Check if the list is empty
            if (tasks.Count == 0)
            {
                Console.WriteLine("There are no tasks to edit.");
                return;
            }

            // Prompt the user for a task index
            Console.Write("Enter the task index: ");
            int index = int.Parse(Console.ReadLine());

            // Check if the index is valid
            if (index < 0 || index >= tasks.Count)
            {
                Console.WriteLine("Invalid index. Type 'list' to see the tasks.");
                return;
            }

            // Prompt the user for a new task description
            Console.Write("Enter the new task description: ");
            string description = Console.ReadLine();

            // Update the task description
            tasks[index].Description = description;

            // Display a confirmation message
            Console.WriteLine("Task edited successfully.");
        }

        // A method to delete an existing task
        static void DeleteTask()
        {
            // Check if the list is empty
            if (tasks.Count == 0)
            {
                Console.WriteLine("There are no tasks to delete.");
                return;
            }

            // Prompt the user for a task index
            Console.Write("Enter the task index: ");
            int index = int.Parse(Console.ReadLine());

            // Check if the index is valid
            if (index < 0 || index >= tasks.Count)
            {
                Console.WriteLine("Invalid index. Type 'list' to see the tasks.");
                return;
            }

            // Remove the task from the list
            tasks.RemoveAt(index);

            // Display a confirmation message
            Console.WriteLine("Task deleted successfully.");
        }

        // A method to mark an existing task as done
        static void MarkTaskAsDone()
        {
            // Check if the list is empty
            if (tasks.Count == 0)
            {
                Console.WriteLine("There are no tasks to mark as done.");
                return;
            }

            // Prompt the user for a task index
            Console.Write("Enter the task index: ");
            int index = int.Parse(Console.ReadLine());

            // Check if the index is valid
            if (index < 0 || index >= tasks.Count)
            {
                Console.WriteLine("Invalid index. Type 'list' to see the tasks.");
                return;
            }

            // Check if the task is already done
            if (tasks[index].Done)
            {
                Console.WriteLine("This task is already done.");
                return;
            }

            // Mark the task as done
            tasks[index].Done = true;

            // Display a confirmation message
            Console.WriteLine("Task marked as done successfully.");
        }

        // A method to list all the tasks
        static void ListTasks()
        {
            // Check if the list is empty
            if (tasks.Count == 0)
            {
                Console.WriteLine("There are no tasks to list.");
                return;
            }

            // Display the tasks with their indexes and statuses
            Console.WriteLine("The tasks are:");
            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i}: {(tasks[i].Done ? "[X]" : "[ ]")} {tasks[i].Description}");
            }
        }

        // A method to exit the program
        static void Exit()
        {
            // Display a farewell message
            Console.WriteLine("Thank you for using the To Do List app!");
            Console.WriteLine("Press any key to exit.");

            // Wait for a key press
            Console.ReadKey();

            // Exit the program
            Environment.Exit(0);
        }
    }
}
