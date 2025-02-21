using System.ComponentModel.Design.Serialization;

namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //generate random number and have user guess
            Random rando = new Random();
            int favoriteNumber = rando.Next(1, 100);
            bool correctGuess = false;
            Console.WriteLine("Guess my favorite number: ");
            do
            {
                int userInput = int.Parse(Console.ReadLine());

                if (userInput > favoriteNumber)
                {
                    Console.WriteLine("Your guess is greater than my favorite number. Guess again: ");
                }
                else if (userInput < favoriteNumber)
                {
                    Console.WriteLine("Your guess is less than my favorite number. Guess again: ");
                }
                else
                {
                    correctGuess = true;
                    Console.WriteLine("You guessed my favorite number, you win!");
                }
            } while (correctGuess == false);
        }
    }
}