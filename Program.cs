using System;
using System.Runtime.ConstrainedExecution;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {

            // Declare Random Object
            Random random = new Random();

            // Declare Variables
            bool playagain = true;
            int min = 1;
            int max = 50;
            int guess;
            int guesses;
            int number;
            String response;

            // create while loop for user play again or not
            while(playagain)
            {

                guess = 0;
                guesses = 0;
                response = "";
                number = random.Next(min, max+1);

                // Guess number is not match with the random number
                while(guess != number)
                {
                    // guess number between given renge 
                    Console.WriteLine("Guess number between " + min + " - " + max +" :");

                    // Read user input and convert into integer
                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Guess : " + guess);

                    // know the user number is high or low for guessing right number
                    if (guess > number)
                    {
                        Console.WriteLine(guess + " is to high");
                    }
                    else if (guess < number)
                    {
                        Console.WriteLine(guess + " is to low");
                    }
                    guesses++;// increment the guesses 
                }
                // After guessing correct number
                Console.WriteLine("Number : "+number);
                
                Console.WriteLine(" \a Congratulation You Win");
                Console.WriteLine("Guesses : "+guesses);

                // Response after completing a game user play again or not
                Console.WriteLine("Would you play again Y/N");
                response = Console.ReadLine();
                response = response.ToUpper();

                // response Y is for playing game 
                if(response == "Y")
                {
                    playagain = true;

                }
                else
                {
                    playagain = false;
                    Console.WriteLine("Thanks for Playing");
                }

                Console.ReadKey();
            }





        }
    }
}