using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tak_Toe
{
    internal class CreateBoard
    {
        static public char[,] Create(int gridSize, int gameState)
        {
            int arraySize = (gridSize * 2) - 1;
            char[,] gameBoard = new char[arraySize, arraySize];
            // GOAL OUTPUT
            //      0           3
            //                  
            //    |   |     1 | 2 | 3
            //  - + - + -   - + - + -
            //    |   |     4 | 5 | 6
            //  - + - + -   - + - + -
            //    |   |     7 | 8 | 9
            // 
            string s;
            for (int i = 0; i < arraySize; i++)
            {
                for (int j = 0; j < arraySize; j++)
                {
                    s = Convert.ToString((j / 2) + (3 * (i / 2)) + 1);
                    if (i % 2 == 1)
                    {
                        if (j % 2 == 1) gameBoard[i, j] = '+';
                        else gameBoard[i, j] = '-';
                    }
                    else 
                    {
                        if (j % 2 == 1) gameBoard[i, j] = '|';
                        else
                        {
                            if (gameState == 0) gameBoard[i, j] = ' ';
                            else if (gameState == 3) gameBoard[i, j] = Convert.ToChar(s);

                        }
                            
                    }
                }
            }
            return gameBoard;
        }        
    }
}
