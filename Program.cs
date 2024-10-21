namespace Tic_Tak_Toe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int gridSize = 3; // GetGridSizeInput()
            // TODO - FUTURE - How many x in a row could I allow? 
            // TODO - FUTURE - Should the winning grid have the x in a row highlighted?
            char[,] createdBoard = CreateBoard.Create(gridSize, 0);
            DisplayBoard.Display(createdBoard, gridSize);

            char[,] userChoiceBoard = CreateBoard.Create(gridSize, gridSize);
            DisplayBoard.Display(userChoiceBoard, gridSize);

            
            // players

            string player1 = "You"; // using 'X' in this case
            string player2 = "The Computer"; // using 'O' in this case
            char winningCharacter = ' ';


            /* MAIN GAME LOOP
             
             TODO - FUTURE - User interface?
            play default difficulty {0}
            (play again {1})
            Change difficulty {2}
            Quit {3}
             TODO - FUTURE - Clear output in console after every move.
             TODO - FUTURE - PVP and/or PVC?

             */


            // I don't have to check a win before 3 moves.

            // Spara i en 0-8 array
            char[] currentBoard = new char[9];

            // Save chosen indexes
            List<int> chosenIndexes = new();

            while (chosenIndexes.Count < 9)
            {
                if (chosenIndexes.Count % 2 == 0)
                {
                    Console.WriteLine("\nWhere do you want to place your next piece? Press (1-9) + Enter ");
                    Console.Write("New move: ");

                    // User input checker
                    int validInt = MoveValidator.UserInput(chosenIndexes);
                    // Add validInt-1 to a list of chosen indexes. user väljer mellan 1-9, i arrayen har jag 0-8.
                    int userInt = validInt - 1;
                    chosenIndexes.Add(userInt);
                    // Add 'X' to the chosen index in the game board Array.
                    currentBoard[userInt] = 'X';
                }
                else
                {
                    /* - The computer generated move - SVÅRT!
                

                    Jag behöver lära mig att split userinput, sätta det i en array och få ut. bla bla.
                    Jag behöver paus och ett mindre lekprogram.
                    */

                    int computerInt = ComputerMove.GetIndex(chosenIndexes);
                    chosenIndexes.Add(computerInt);
                    currentBoard[computerInt] = 'O';
                }

                // TODO - CURRENT - display currentBoard.


                // Check the win!
                winningCharacter = CheckWin.True(currentBoard);
                if (winningCharacter != 'N')
                {
                    break; // Break out! Player 1/Player2 has won!
                }
            }
            
            // Game finished!
            
            if (winningCharacter != 'N')
            {
                string result = winningCharacter == 'X' ? $"{player1} have" : $"{player2} has";
                Console.WriteLine($"{result} won!");
            }
            else
            {
                Console.WriteLine("It's a draw!");
            }
        }
    }    
}
