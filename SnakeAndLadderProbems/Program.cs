using System;

namespace SnakeAndLadderProbems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder program");
            Console.WriteLine("Please enter option given below");
            Console.WriteLine("1:Player Position\n2:DieRolled\n3:CheckPosition\n4:win condition\n5:Exact win position of player");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    SnakeAndLadder.Position();
                    break;

                case 2:
                    SnakeAndLadder.DieRolled();
                    break;

                case 3:
                    SnakeAndLadder.CheckPosition();
                    break;

                case 4:
                    SnakeAndLadder.WinCondition();
                    break;

                case 5:
                    SnakeAndLadder.WinCondition();
                    break;
            }
        }
    }
}
