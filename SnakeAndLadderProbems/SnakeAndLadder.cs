using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
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
        // UC3 programs
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
        // UC5 programs modified to UC6 Report the number of times the dice was played to win the game and also the position after every die role
        public static void WinCondition()
        {
            int position = 0;
            int count = 0;
            Random random = new Random();
            Random random1 = new Random();
            while (position < 100)
            {
                int dieRoll = random.Next(1, 7);
                int option = random1.Next(1, 4);
                count = count + 1;
                switch (option)
                {
                    case 1:
                        position = position + dieRoll;
                        if (position > 100)
                            position = 100;
                        Console.WriteLine("Player move ahead by number of Die rolled " + position);
                        break;
                    case 2:
                        position = position - dieRoll;
                        if (position < 0)
                            position = 0;
                        Console.WriteLine("Player move behind by number of Die rolled " + position);
                        break;
                    case 3:
                        Console.WriteLine("Player remain at same position " + position);
                        break;
                }
            }

            Console.WriteLine("The number of time dice rolled to get winning position " + count);
        }
    }
}
        
      

