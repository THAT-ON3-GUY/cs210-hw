using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNum = randomGenerator.Next(1, 50);

        string guess = "";
        int guessNum = 0;

        do
        {
            Console.WriteLine("What is your guess? ");
            guess = Console.ReadLine();
            guessNum = int.Parse(guess);

            if (guessNum < magicNum)
            {
                Console.WriteLine("Higher");
            }
            else if(guessNum > magicNum)
            {
                Console.WriteLine("Lower");
            }
            else if(guessNum == magicNum)
            {
                Console.WriteLine("You guessed it!");
            }
            else
            {
                Console.WriteLine("What did you do?");
            }  
        } while (guessNum != magicNum);


    }
}