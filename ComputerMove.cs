using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tak_Toe
{
    internal class ComputerMove
    {
        public static int GetIndex(List<int> chosenIndexes)
        {
            int index = 0;
            /*
            3 svårighetsgrader
                    1.Random drag
                        - Kanske lättast att börja med.
                    2.Random 1st move, then Shortsighted = Greedy
                    3.Perfect human play
                        - svårt med drag 2!
                    4.Cheater = datorn spelar på ett större grid(5x5 istf 3x3)
                Thread.Sleep(~3000) när datorn "gör sitt drag"
            */


            // 1.Random drag
            // -Kanske lättast att börja med.

            List<int> availableIndexes = new List<int>();
            availableIndexes = [0, 1, 2, 3, 4, 5, 6, 7, 8];
            for (int i = 0; i < chosenIndexes.Count; i++)
            {
                availableIndexes.Remove(chosenIndexes[i]);
            }
            // I just hope that the list re-adjusts itself.
            Random random = new();
            index = availableIndexes[random.Next(0, availableIndexes.Count-1)];



            // TODO - FUTURE - 3.Perfect human play

            // ------------- 1st Move: Middle or Corners

            /* if chosenIndexes.Count() == 1;
            if (chosenIndexes.Count == 1)
            {
                // If 4 is an available index, place there.
                if (!chosenIndexes.Contains(4))
                {
                    index = 4;
                    return index;
                }
                // else return random index (0, 2, 6, 8)
                else
                {
                    List<int> cornerIndexes = [0, 2, 6, 8];
                    Random randomIndex = new Random();
                    index = cornerIndexes[randomIndex.Next(0, 3)];
                    return index;
                }
            }
            */
            // ------------- Offence Move - The computer must go for the win if possible.

            // If the FIRST FOUND index i is available in ChosenIndex that wins the game for the Computer, place there
            // else, go to Defence.


            // ------------- Defence Move - The computer must defend if no win is possible.

            // If the FIRST FOUND index i is available in ChosenIndex that wins the game for the User, place there.

            // TODO - FUTURE - Recursive function solve for Comp 2nd move? Example:
            // player X Comp O
            // 
            // X O
            //     X
            // The only moves that the computer has to place it in is 1, 7 or 8 which right now isn't clear.
            // If 2, or 3, then user will block in 7 or 8 and then the game is lost.
            // Conclusion: If the first found index i will be blocked by index j that ensures human win then index i is wack

            return index;
        }
    }
}
