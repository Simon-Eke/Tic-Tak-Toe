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
            char playerCharacter;


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

            while (true)
            {
                Console.WriteLine("\nWhere do you want to place your next piece? Press (1-9) + Enter ");
                Console.Write("New move: ");

                // User input checker
                int validInt = MoveValidator.UserInput(chosenIndexes);
                // Add validInt to a list of chosen indexes. user väljer mellan 1-9, i arrayen har jag 0-8.
                chosenIndexes.Add(validInt-1);
                // Add 'X' to the chosen index in the game board Array.
                currentBoard[validInt] = 'X';


                // TODO - NEAR FUTURE - display currentBoard.


                // Check the win for the player!

                playerCharacter = CheckWin.True(currentBoard);

                if (playerCharacter != 'N')
                {
                    break; // Break out! Player 1/Player has won!
                }


                /* TODO - CURRENT - The computer generated move - SVÅRT!
                int computerInt = ComputerMove.GetIndex(chosenIndexes);
                chosenIndexes.Add(computerInt - 1????);
                currentBoard[computerInt] = 'O';

                Jag behöver lära mig att split userinput, sätta det i en array och få ut. bla bla.
                Jag behöver paus och ett mindre lekprogram.
                */


                // Check the win for the computer!

                playerCharacter = CheckWin.True(currentBoard);

                if (playerCharacter != 'N')
                {
                    break; // Break out! Player 2/Computer has won!
                }
            }

            // Game finished!

            string result = playerCharacter == 'X' ? $"{player1} have" : $"{player2} has";
            Console.WriteLine($"{result} won!");

        }
    }    
}
