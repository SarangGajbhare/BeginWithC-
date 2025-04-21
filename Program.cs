using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main ( string[] args )
        {
            // Create Random class object
            Random random = new Random();

            //declare a variables
            bool play = true;
            String player;
            String computer;
            String answer;

            // create while loop for start the game
            while (play)
            {
                player = ""; 
                computer = "";
                answer = "";

                // enter a valid input from the user
                while(player != "ROCK" && player != "PAPER" && player != "SCISSORS" )
                {
                    
                    Console.Write("Enter a ROCK PAPER or SCISSORS : ");                 
                    player = Console.ReadLine();
                    player = player.ToUpper();

                }
                // random number choose by the computer 1 to 4 
                // 4 is exclusive
                // random number is generate 1 to 3
                switch (random.Next(1 ,4))
                {
                    case 1:
                        computer = "ROCK";
                        break;

                    case 2:
                        computer = "PAPER";
                        break ;

                    case 3:
                        computer = "SCISSORS";
                        break ; 

                }
                // show the chooses option
                Console.WriteLine("Player : " + player);
                Console.WriteLine("Computer : " + computer);

                switch (player)
                {
                    //player side
                    case "ROCK":

                        // computer side
                        if (computer == "ROCK")
                        {
                            // Result
                            Console.WriteLine("It's Draw");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("You Lose");
                        }
                        else
                        {
                            Console.WriteLine("You Win");
                        }

                        break;

                    case "PAPER":

                        if (computer == "ROCK")
                        {
                            Console.WriteLine("You Win");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("It's Draw");
                        }
                        else
                        {
                            Console.WriteLine("You Lose");
                        }
                        break ;

                    case "SCISSORS":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("You Lose");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("You Win");
                        }
                        else
                        {
                            Console.WriteLine("It's Draw");
                        }
                       
                        break;

                }

                // playing the again or not
                Console.WriteLine("Would You Like to play again Y/N : ");
                answer = Console.ReadLine();
                answer = answer.ToUpper();
                    if (answer == "Y")
                {
                    play = true;
                }
                    else
                {
                    play = false;
                }

                

            }
            // after pressing N 
            Console.WriteLine("Thanks For Playing");




            Console.ReadKey();  
        }
    }
}