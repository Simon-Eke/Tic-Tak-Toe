using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tak_Toe
{
    internal class DisplayBoard
    {
        static public void Display(char[,] createdBoard, int gridSize)
        {
            int length = (gridSize * 2) - 1;
            // GOAL OUTPUT
            //      0           3
            //                  
            //    |   |     1 | 2 | 3
            //  - + - + -   - + - + -
            //    |   |     4 | 5 | 6
            //  - + - + -   - + - + -
            //    |   |     7 | 8 | 9
            // 


            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    string row = $"{createdBoard[i, j]}";                    
                    Console.Write(row.PadLeft(2));
                }                
                Console.WriteLine("");
            }
            Console.WriteLine("");
        }
    }
}
