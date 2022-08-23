﻿namespace SnakeAndLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder");
            int NUMBER_OF_PLAYERS = 1;
            int START_POSITION = 0;
            int presentPosition = 0;
            const int NO_PLAY = 0;
            const int LADDER = 1;
            const int SNAKE = 2;
            Random random = new Random();
            while (presentPosition < 100)
            {
                int numberOnDie = random.Next(1, 7);
                int optionNumber = random.Next(0, 3);
                switch (optionNumber)
                {
                    case NO_PLAY:
                        break;
                    case LADDER:
                        presentPosition += numberOnDie;
                        break;
                    case SNAKE:
                        presentPosition -= numberOnDie;
                        if (presentPosition < 0)
                            presentPosition = 0;
                        break;

                }
            }
            Console.WriteLine(presentPosition);


        }
    }
}