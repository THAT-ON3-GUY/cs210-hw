using System.IO;

public class Journal
{
    public List<string> _entries = new List<string>();

    
    

    public void WriteEntry()
    {
        string entryDate = DateTime.Now.ToShortDateString();
        PromptGen prompt = new PromptGen();
        string givenPrompt = prompt.DisplayPrompt();
        Console.WriteLine("Write your Journal Entry Below");
        string entry = "Date: " + entryDate + " | " + "Prompt:" + givenPrompt + " | " + Console.ReadLine();
        _entries.Add(entry);
    }

    public void DisplayEntries()
    {
        foreach (string entry in _entries)
        {
            Console.WriteLine(entry);
        }
    }

    public void SaveEntries()
    {
        Console.WriteLine("What filename would you like to save your journal under?: ");
        string filename = Console.ReadLine() + ".txt";
        
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (string entry in _entries)
            {
                outputFile.WriteLine(entry);
            }
        }
    }

    public void LoadEntries()
    {
        Console.WriteLine("What file would you like to load?: ");
        string filename = Console.ReadLine() + ".txt";

        if (File.Exists(filename))
        {
            string[] loadedEntries = System.IO.File.ReadAllLines(filename);
            _entries.Clear();
            _entries.AddRange(loadedEntries);  
        }
        //Covered Edge Case of Incorrect input
        else
        {
            Console.WriteLine("File not found!");
        }
        

    }
}