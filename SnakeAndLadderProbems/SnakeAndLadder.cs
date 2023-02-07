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
    }
}
