using System;

class Program
{
    static void Main(string[] args)
    {
        // Create an Address object
        Address address = new Address("123 Main St", "Anytown", "CA", "12345");

        // Create a Lecture event
        Lecture lecture = new Lecture("Tech Talk", "A talk about technology.", new DateTime(2024, 6, 15), new DateTime(2024, 6, 15, 14, 0, 0), address, "John Doe", 100);

        // Create a Reception event
        Reception reception = new Reception("Networking Event", "An evening of networking.", new DateTime(2024, 6, 20), new DateTime(2024, 6, 20, 18, 0, 0), address, "rsvp@example.com");

        // Create an Outdoor Gathering event
        OutdoorGathering outdoorGathering = new OutdoorGathering("Picnic", "A fun picnic in the park.", new DateTime(2024, 6, 25), new DateTime(2024, 6, 25, 12, 0, 0), address, "Sunny");

        // Print standard details for each event
        Console.WriteLine("Standard Details:");
        lecture.PrintStandardDetails();
        Console.WriteLine();
        reception.PrintStandardDetails();
        Console.WriteLine();
        outdoorGathering.PrintStandardDetails();
        Console.WriteLine();

        // Print full details for each event
        Console.WriteLine("Full Details:");
        lecture.PrintFullDetails();
        Console.WriteLine();
        reception.PrintFullDetails();
        Console.WriteLine();
        outdoorGathering.PrintFullDetails();
        Console.WriteLine();

        // Print short descriptions for each event
        Console.WriteLine("Short Descriptions:");
        lecture.PrintShortDescription();
        Console.WriteLine();
        reception.PrintShortDescription();
        Console.WriteLine();
        outdoorGathering.PrintShortDescription();
    }
}