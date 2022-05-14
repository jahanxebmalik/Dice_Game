using System;
using System.Threading;

namespace Dice_Game
{
    class Program
    {
        static void Main(string[] args)
        {

            int playerRandomNum;
            int enemyRandomNum;

            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Press any key to roll the dice!");
                Console.ReadKey();
                playerRandomNum = random.Next(1, 7);
                Console.WriteLine("Player rolled: " + playerRandomNum);

                Thread.Sleep(1000);

                enemyRandomNum = random.Next(1, 7);
                Console.WriteLine("Enemy rolled: " + enemyRandomNum);
                Console.ReadKey();
            }
        }
    }
}
