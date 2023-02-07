using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderProbems
{
    internal class SnakeAndLadder
    {
        // UC1 Program
        public static void Position()
        {
            int position = 0;
            Console.WriteLine("The Player starts with Position {0}", position);
        }

        // UC2 program
        public static void DieRolled()
        {
            Random random = new Random();
            int dieRoll = random.Next(1, 7);
            Console.WriteLine("The random number of die: " + dieRoll);
        }

        public static void CheckPosition()
        {
            int position = 0;
            Console.WriteLine("The position of player start with {0}", position);
            Random random = new Random();
            int dieRoll = random.Next(1, 7);
            Console.WriteLine("The random number of dice: " + dieRoll);
            Random random1 = new Random();
            int option = random1.Next(1, 4);
            switch (option)
            {
                case 1:
                    Console.WriteLine("Player remain at same position " + position);
                    break;
                case 2:
                    position = position + dieRoll;
                    Console.WriteLine("Player move ahead by number of Die rolled " + position);
                    break;
                case 3:
                    position = position - dieRoll;
                    Console.WriteLine("Player move behind by number of die rolled " + position);
                    break;
                }
            }
        }
}
