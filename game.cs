using System;
using System.ComponentModel.Design;

namespace Dice_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dice Game");

            int PlayerRandomNum;
            int EnemyRandomNum;

            int PlayerScore = 0;
            int EnemyScore = 0;
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                //player
                Console.WriteLine("press enter key to roll dice.");
                PlayerRandomNum = random.Next(1, 7);
                Console.ReadKey();
                Console.WriteLine("you rolled a " + PlayerRandomNum);

                //enemy
                EnemyRandomNum = random.Next(1, 7);
                Console.WriteLine("your oppnent rolled a " + EnemyRandomNum);

                //player
                if (PlayerRandomNum > EnemyRandomNum)
                {
                    Console.WriteLine("you win");
                    ++PlayerScore; 
                }
                //opponent
                else if (EnemyRandomNum < PlayerScore)
                {
                    Console.WriteLine("enemy player wins");
                    ++EnemyScore;
                }
                //draw
                else
                {
                    Console.WriteLine("draw");
                }
                Console.WriteLine(" ");
                Console.WriteLine("player: " + PlayerScore);
                Console.WriteLine("opponent: " + EnemyScore);
                Console.WriteLine(" ");
                Console.WriteLine(" ");

            }
            

            Console.ReadKey();
        }
    }
}
