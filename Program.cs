using System;

namespace Rock_Paper_Scissors
{
    class Program
    {
        static void Main(string[] args)
        {

            string inputPlayer;
            int randomInt;

            bool playAgain = true;

            while (playAgain)
            {

                int scorePlayer = 0;
                int scoreComputer = 0;

                while (scorePlayer < 3 && scoreComputer < 3)
                {


                    Console.Write("Choose between ROCK, PAPER and SCISSORS:    ");
                    inputPlayer = Console.ReadLine();
                    inputPlayer = inputPlayer.ToUpper();

                    Random rnd = new Random();

                    randomInt = rnd.Next(1, 4);

                    switch (randomInt)
                    {
                        case 1:
                            
                            Console.WriteLine("Computer chose ROCK");
                            
                            if (inputPlayer == "R")
                            {
                                
                                Console.WriteLine("DRAW!!\n\n");
                            }
                            else if (inputPlayer == "P")
                            {
                                Console.WriteLine("You WIN!!\n\n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "S")
                            {
                                Console.WriteLine("Computer WINS!!\n\n");
                                scoreComputer++;
                            }
                            break;
                        case 2:
                            Console.WriteLine("Computer chose PAPER");
                            if (inputPlayer == "P")
                            {
                                Console.WriteLine("DRAW!!\n\n");
                            }
                            else if (inputPlayer == "R")
                            {
                                Console.WriteLine("Computer WINS!!\n\n");
                                scoreComputer++;
                            }
                            else if (inputPlayer == "S")
                            {
                                Console.WriteLine("You WINS!!\n\n");
                                scorePlayer++;
                            }
                            break;
                        case 3:
                            Console.WriteLine("Computer chose SCISSORS");
                            if (inputPlayer == "S")
                            {
                                Console.WriteLine("DRAW!!\n\n");
                            }
                            else if (inputPlayer == "R")
                            {
                                Console.WriteLine("You WINS!!\n\n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "P")
                            {
                                Console.WriteLine("Computer WINS!!\n\n");
                                scoreComputer++;
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid entry!");
                            break;
                    }

                    Console.WriteLine("\n\nSCORES:\tPLAYER:\t{0}\tComputer:\t{1}", scorePlayer, scoreComputer);

                }

                if (scorePlayer == 3)
                {
                    Console.WriteLine("You WON!");
                }
                else if (scoreComputer == 3)
                {
                    Console.WriteLine("Comptuer WON!");
                }
                else
                {

                }

                Console.WriteLine("Do you want to play again?(y/n)");
                string loop = Console.ReadLine();
                if (loop == "y")
                {
                    playAgain = true;
                    Console.Clear();
                }
                else if (loop == "n")
                {
                    playAgain = false;
                }
               
            }
        }
    }
}
