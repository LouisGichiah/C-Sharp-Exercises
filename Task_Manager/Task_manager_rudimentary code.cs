using System;

class Task_manager
{
    static void Main()
    {
        string task1 = "";
        string task2 = "";
        string task3 = "";
        bool taskOneIsCompleted = false;
        bool taskTwoIsCompleted = false;
        bool taskThreeIsCompleted = false;

        while (true)
        {
            Console.WriteLine("\nMain Menu");
            Console.WriteLine("1. Enter a Task");
            Console.WriteLine("2. Mark Task As Completed");
            Console.WriteLine("3. Display Tasks and Status");
            Console.WriteLine("4. Exit");
            Console.Write("Please select an option (1-4): ");
            string selectOption = Console.ReadLine();

            if (selectOption == "1")
            {
                Console.Write("Please input your task: ");
                string inputTask = Console.ReadLine();

                if (task1 == "")
                {
                    task1 = inputTask;
                    Console.WriteLine("Task 1 added.");
                }
                else if (task2 == "")
                {
                    task2 = inputTask;
                    Console.WriteLine("Task 2 added.");
                }
                else if (task3 == "")
                {
                    task3 = inputTask;
                    Console.WriteLine("Task 3 added.");
                }
                else
                {
                    Console.WriteLine("Cannot add any more tasks. All slots are full.");
                }
            }
            else if (selectOption == "2")
            {
                Console.Write("Enter the task number to mark as completed (1-3): ");
                string markComplete = Console.ReadLine();

                if (markComplete == "1" && task1 != "")
                {
                    taskOneIsCompleted = true;
                    Console.WriteLine("Task 1 marked as completed.");
                }
                else if (markComplete == "2" && task2 != "")
                {
                    taskTwoIsCompleted = true;
                    Console.WriteLine("Task 2 marked as completed.");
                }
                else if (markComplete == "3" && task3 != "")
                {
                    taskThreeIsCompleted = true;
                    Console.WriteLine("Task 3 marked as completed.");
                }
                else
                {
                    Console.WriteLine("Invalid task number or task not available.");
                }
            }
            else if (selectOption == "3")
            {
                Console.WriteLine("\nTask List:");
                bool hasTasks = false;

                if (task1 != "")
                {
                    string status = taskOneIsCompleted ? "Completed" : "Pending";
                    Console.WriteLine("1. " + task1 + " - " + status);
                    hasTasks = true;
                }
                if (task2 != "")
                {
                    string status = taskTwoIsCompleted ? "Completed" : "Pending";
                    Console.WriteLine("2. " + task2 + " - " + status);
                    hasTasks = true;
                }
                if (task3 != "")
                {
                    string status = taskThreeIsCompleted ? "Completed" : "Pending";
                    Console.WriteLine("3. " + task3 + " - " + status);
                    hasTasks = true;
                }

                if (!hasTasks)
                {
                    Console.WriteLine("No tasks to display.");
                }
            }
            else if (selectOption == "4")
            {
                Console.WriteLine("Exiting the program... Thank you!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid selection. Please choose between 1 and 4.");
            }
        }
    }
}
