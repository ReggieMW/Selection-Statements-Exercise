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
            
            
            //user's favorite school subject
            Console.WriteLine("What is your favorite school subject?");
            string favoriteSubject = Console.ReadLine();
            
            switch (favoriteSubject)
            {
                case "math":
                    Console.WriteLine("Mathematics knowledge can really come in handy with programming.");
                    break;
                case "science":
                    Console.WriteLine("Scientist are great at using experiments and data to figure out how the world works, but no one listens to them.");
                    break;
                case "history":
                    Console.WriteLine("Historians are very knowledgeable about how to fix society but no one listens to them.");
                    break;
                case "english":
                    Console.WriteLine("English majors make great servers and bartenders!");
                    break;
                case "art":
                    Console.WriteLine("You're a beautiful soul but AI is going to take your job so maybe you can teach?");
                    break;
                default:
                    Console.WriteLine("Oooooo-kay, yeah, so have fun with that.");
                    break;
            }
        }
    }
}