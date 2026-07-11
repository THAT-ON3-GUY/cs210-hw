using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a video
        Video video = new Video("My Video", "John Doe", 120);

        // Add comments to the video
        video.AddComment(new Comment("Alice", "Great video!"));
        video.AddComment(new Comment("Bob", "I learned a lot."));
        video.AddComment(new Comment("Charlie", "Thanks for sharing!"));
        video.AddComment(new Comment("Diana", "Very informative."));


        // Display video information
        Console.WriteLine("--- Video 1 ---");
        Console.WriteLine($"Title: {video.Title}");
        Console.WriteLine($"Author: {video.Author}");
        Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
        Console.WriteLine("Comments:");

        // Display comments
        foreach (Comment comment in video.Comments)
        {
            Console.WriteLine($"- {comment.Writer}: {comment.Text}");
        }

        Video video1 = new Video("Funny Clip", "Jane Doe", 120);
        video1.AddComment(new Comment("David", "Hilarious!"));
        video1.AddComment(new Comment("Eve", "Best video ever!"));
        video1.AddComment(new Comment("Frank", "I can't stop laughing."));
        video1.AddComment(new Comment("Grace", "This made my day!"));

        Console.WriteLine("\n--- Video 2 ---");
        Console.WriteLine($"Title: {video1.Title}");
        Console.WriteLine($"Author: {video1.Author}");
        Console.WriteLine($"Length: {video1.LengthInSeconds} seconds");
        Console.WriteLine("Comments:");

        foreach (Comment comment in video1.Comments)
        {
            Console.WriteLine($"- {comment.Writer}: {comment.Text}");
        }

        Video video2 = new Video("Educational Tutorial", "Mark Smith", 300);
        video2.AddComment(new Comment("Frank", "Very informative."));   
        video2.AddComment(new Comment("Grace", "I learned a lot from this tutorial."));
        video2.AddComment(new Comment("Hannah", "Thanks for sharing your knowledge."));
        video2.AddComment(new Comment("Ian", "This tutorial was very helpful."));

        Console.WriteLine("\n--- Video 3 ---");
        Console.WriteLine($"Title: {video2.Title}");
        Console.WriteLine($"Author: {video2.Author}");
        Console.WriteLine($"Length: {video2.LengthInSeconds} seconds");
        Console.WriteLine("Comments:");

        foreach (Comment comment in video2.Comments)
        {
            Console.WriteLine($"- {comment.Writer}: {comment.Text}");
        }

        Video video3 = new Video("Travel Vlog", "Emily Johnson", 180);
        video3.AddComment(new Comment("Hannah", "Beautiful scenery!"));
        video3.AddComment(new Comment("Ian", "I want to visit this place!"));
        video3.AddComment(new Comment("Jack", "Amazing travel experience."));
        video3.AddComment(new Comment("Karen", "I love the way you captured the culture."));

        Console.WriteLine("\n--- Video 4 ---");
        Console.WriteLine($"Title: {video3.Title}");
        Console.WriteLine($"Author: {video3.Author}");
        Console.WriteLine($"Length: {video3.LengthInSeconds} seconds");
        Console.WriteLine("Comments:");

        foreach (Comment comment in video3.Comments)
        {
            Console.WriteLine($"- {comment.Writer}: {comment.Text}");
        }
    }
}