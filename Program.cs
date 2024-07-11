using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    internal class Program
    {
        static int RandomNumber()
        {
            Random rand = new Random();
            int randomNumber = rand.Next(1, 100);
            return randomNumber;
        }

        static void NumberGuessor()
        {
            int guess;
            int numberOfGuesses = 3;
            int totalGuess = 1;
            int randomNumber = RandomNumber();
            Console.WriteLine("Hello, welcome to guess the number game");

            while (numberOfGuesses > 0)
            {
                Console.WriteLine("Enter your Guess");
                guess = Convert.ToInt32(Console.ReadLine());

                if (randomNumber == guess)
                {
                    Console.WriteLine("You have guessed it correctly, congratulation in " + totalGuess + "attempts");
                    break;
                }
                else if (guess > randomNumber)
                    Console.WriteLine("Too High " + "Try again, you have " + (numberOfGuesses - 1) + " more attempts");
                else
                    Console.WriteLine("Too Low " + "Try again, you have " + (numberOfGuesses - 1) + " more attempts");
                numberOfGuesses--;
                totalGuess++;
                if (numberOfGuesses <= 0)
                    Console.WriteLine("the correct guess was " + randomNumber);
            }
        }
        
        static bool PlayAgain()
        {
            Console.WriteLine("Do you want to play again?  type 1 to play again, type 0 to exit");
            int response = Convert.ToInt32(Console.ReadLine());
            while (true) {
                if (response == 1)
                    return true;
                else if (response == 0)
                    return false;
                else
                {
                    Console.WriteLine("invalid output");
                    PlayAgain();
                    return true;
                }
            }
        }
        static void Main(string[] args)
        {

            bool playAgain = true;
            while (playAgain) {
                NumberGuessor();
                playAgain = PlayAgain();
            }

            Console.WriteLine("Exited Game over");       

        }
    }
}
