﻿using System;

namespace SnakeAndLadderProbems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder program");
            Console.WriteLine("Please enter option given below");
            Console.WriteLine("1:Player Position");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    SnakeAndLadder.Position();
                    break;
            }
        }
    }
}