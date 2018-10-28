using System;

namespace LittleSpeedyToyRobot
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayWithSpeedy();
        }

        private static void PlayWithSpeedy()
        {
            GreetPlayer();
            PlaceSpeedy();
        }

        private static void PlaceSpeedy()
        {
            bool placedCorrectly = false;
            while (!placedCorrectly)
            {
                Console.WriteLine("Come on, try placing Little Speedy!");
                Console.WriteLine("Examples of inputs:");
                Console.WriteLine("PLACE 3, 1, NORTH");
                Console.WriteLine("or");
                Console.WriteLine("PLACE 2, 2, EAST");
                string placeCommand = Console.ReadLine();
                if (String.IsNullOrEmpty(placeCommand))
                {
                    continue;
                }
                placeCommand = placeCommand.Trim();
                if (!placeCommand.StartsWith("PLACE"))
                {
                    continue;
                }
                //  .. to be continued
            }
        }

        private static void GreetPlayer()
        {
            Console.WriteLine("Hello there! time to play with Little Speedy, our new robot!");
            Console.WriteLine("Even though you will try to drop little Speedy off the table, he is smart enough to ignore that command");
            Console.WriteLine("Commands that Speedy understands: PLACE, MOVE, LEFT, RIGHT, REPORT");
            Console.WriteLine("First place Speedy on the table, using the following command: PLACE {x position}, {y position}, {direction} Speedy is facing");
        }
    }
}
