using System;

class Program
{
    static void Main(string[] args)
    {
            MathAssignment testMath = new MathAssignment("John Test", "Math Test", "Section 1", "Problems 1-10");
            Console.WriteLine(testMath.GetSummary());
            Console.WriteLine(testMath.GetHomeworkList());

            WritingAssignment testWriting = new WritingAssignment("John Test", "Writing Test", "That one book");
            Console.WriteLine(testWriting.GetSummary());
            Console.WriteLine(testWriting.GetWritingInformation());
    }
}