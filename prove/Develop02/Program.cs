using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        string choice = "0";
        while (choice != "5")
        {
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            choice = Console.ReadLine();

            if(choice == "1")
            {
                journal.WriteEntry();

            }
            else if(choice == "2")
            {
                journal.DisplayEntries();
            }
            else if(choice == "3")
            {
                journal.LoadEntries();
            }
            else if(choice == "4")
            {
                journal.SaveEntries();
            }
            else if(choice != "5")
            {
                Console.WriteLine("Operation not recognized, please input a number from 1-5!");
            }
        }
        


        
    }
}