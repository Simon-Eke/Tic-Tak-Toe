using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tak_Toe
{
    internal class MoveValidator
    {
        // Parses user input and validates until valid number or terminates if user doesn't comply.
        public static int UserInput(List<int> chosenIndexes)
        {
            int userPositionChoice;
            bool validMove = false;
            int inputTries = 3;
            do
            {
                validMove = int.TryParse(Console.ReadLine(), out userPositionChoice);
                
                if (!validMove)
                {
                    Console.WriteLine("Only a number is allowed, no text or special characters.");
                    inputTries--;
                    Thread.Sleep(1000);
                    Console.Write("New move: ");
                }
                else if (userPositionChoice > 9 || userPositionChoice < 1)
                {
                    Console.WriteLine("You must choose a whole number between (1-9)");
                    inputTries--;
                    Thread.Sleep(1000);
                    Console.Write("New move: ");
                    validMove = false;
                }
                else if (chosenIndexes.Contains(userPositionChoice))
                {
                    Console.WriteLine("You must choose a vacant position.");
                    inputTries--;
                    Thread.Sleep(1000);
                    Console.Write("New move: ");
                    validMove = false;
                }
            } while (!validMove && inputTries > 0);

            // Termination of game due to misbehaving user.
            if (inputTries == 0)
            {
                Console.WriteLine("\n---------\nThe program will now terminate due to your way of ignoring the rules of the Game\n---------");
                Thread.Sleep(3000);
                Console.Clear();
                string gameOver = "---------  G A M E  O V E R  ---------";
                Console.WriteLine($"\n\n\n\n{gameOver.PadLeft(75)}\n\n\n\n");
                Environment.Exit(0);
            }
            
            return userPositionChoice;
        }
    }
}
