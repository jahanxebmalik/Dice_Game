using System;
using System.Threading;

namespace Dice_Game
{
    class Program
    {
        static void Main(string[] args)
        {

            int playerRandomNum;
            int computerRandomNum;

            int roundNum;

            int playerWins = 0;
            int computerWins = 0;
            int draw = 0;

            Random random = new Random();
            Console.Write("Enter the number of rounds: ");
            roundNum = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < roundNum; i++)
            {
                Console.WriteLine("Press any key to roll the dice!");
                Console.ReadKey();
                playerRandomNum = random.Next(1, 7);
                Console.WriteLine("Player rolled: " + playerRandomNum);

                Thread.Sleep(1000);

                computerRandomNum = random.Next(1, 7);
                Console.WriteLine("Computer rolled: " + computerRandomNum);


                if (playerRandomNum > computerRandomNum)
                {
                    playerWins++;
                    Console.WriteLine("Player Score: " + playerWins + " : " + "Computer Score: " + computerWins);
                }
                else if (playerRandomNum < computerRandomNum)
                {
                    computerWins++;
                    Console.WriteLine("Player Score: " + playerWins + " : " + "Computer Score: " + computerWins);
                }
                else
                {
                    draw++;
                    Console.WriteLine("It's a draw");
                }
            }
            Console.WriteLine("--------------");

            if (playerWins > computerWins)
            {
                Console.WriteLine("Final Score- \r\nPlayer: " + playerWins + "\r\nComputer: " + computerWins + "\r\nDraw: " + draw);
                Console.WriteLine("Player wins!");
            }
            else if (playerWins < computerWins)
            {
                Console.WriteLine("Final Score- \r\nPlayer: " + playerWins + "\r\ncomputer: " + computerWins + "\r\nDraw: " + draw);
                Console.WriteLine("Computer wins!");
            }
            else
            {
                Console.WriteLine("Final Score- \r\nPlayer: " + playerWins + "\r\nComputer: " + computerWins + "\r\nDraw: " + draw);
                Console.WriteLine("It's a draw");
            }
        }
    }
}
