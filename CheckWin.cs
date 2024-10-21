using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tak_Toe
{
    internal class CheckWin
    {
        // Checks win by returning the character of the winner or 'N' if no winner.
        public static char True(char[] winningBoard)
        {
            char bigX = 'X';
            char bigO = 'O';
            char winner;
            char noWinnerYet = 'N';


            // X X X

            for (int i = 0; i < 7; i += 3)
            {
                if (winningBoard[i] == bigO && winningBoard[i + 1] == bigO && winningBoard[i + 2] == bigO)
                {
                    winner = bigO;
                    return winner;
                }
                else if (winningBoard[i] == bigX && winningBoard[i + 1] == bigX && winningBoard[i + 2] == bigX)
                {
                    winner = bigX;
                    return winner;
                }
            }


            // X
            // X
            // X

            for (int i = 0; i < 3; i++)
            {
                if (winningBoard[i] == bigO && winningBoard[i + 3] == bigO && winningBoard[i + 6] == bigO)
                {
                    winner = bigO;
                    return winner;
                }
                else if (winningBoard[i] == bigX && winningBoard[i + 3] == bigX && winningBoard[i + 6] == bigX)
                {
                    winner = bigX;
                    return winner;
                }
            }


            // X        
            //   X      
            //     X    

            if (winningBoard[4 - 4] == bigO && winningBoard[4] == bigO && winningBoard[4 + 4] == bigO)
            {
                winner = bigO;
                return winner;
            }
            else if (winningBoard[4 - 4] == bigX && winningBoard[4] == bigX && winningBoard[4 + 4] == bigX)
            {
                winner = bigX;
                return winner;
            }

            //     X
            //   X
            // X

            if (winningBoard[4 - 2] == bigO && winningBoard[4] == bigO && winningBoard[4 + 2] == bigO)
            {
                winner = bigO;
                return winner;
            }
            else if (winningBoard[4 - 2] == bigX && winningBoard[4] == bigX && winningBoard[4 + 2] == bigX)
            {
                winner = bigX;
                return winner;
            }


            // TODO - Check draw after array is full or Chosen indexes is filled with 0-8
            // if noone has won return no winner yet = 'N'

            return noWinnerYet;
            
        }
    }
}
