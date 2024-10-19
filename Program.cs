namespace Tic_Tak_Toe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int gridSize = 3; // GetGridSizeInput()
            // TODO - How many x in a row could I allow? 
            // TODO - Should the winning grid have the x in a row highlighted?
            char[,] createdBoard = CreateBoard.Create(gridSize, 0);
            DisplayBoard.Display(createdBoard, gridSize);

            char[,] userChoiceBoard = CreateBoard.Create(gridSize, gridSize);
            DisplayBoard.Display(userChoiceBoard, gridSize);

            
            // players

            string player1 = "You"; // using 'X' in this case
            string player2 = "The Computer"; // using 'O' in this case
            char playerCharacter;


            /* MAIN GAME LOOP
             
             TODO - User interface?
             TODO - Clear output in console after every move.
             
             */


            // I don't have to check a win before 3 moves.

            // Spara i en 0-8 array
            char[] currentBoard = new char[9];

            // Save chosen indexes
            List<int> chosenIndexes = new();

            while (true)
            {
                Console.WriteLine("\nWhere do you want to place your next piece? (1-9) ");
                Console.Write("New move: ");

                // User input checker
                int validInt = MoveValidator.UserInput(chosenIndexes);
                // Add validInt to a list of chosen indexes.
                chosenIndexes.Add(validInt);
                // Add 'X' to the chosen index in the game 
                currentBoard[validInt] = 'X';


                // TODO - display currentBoard.


                // Check the win for the player!

                playerCharacter = CheckWin.True(currentBoard);

                if (playerCharacter != 'N')
                {
                    break; // Break out! Someone has won!
                }


                /* TODO - The computer generated move
                
                
                */


                // Check the win for the computer!

                playerCharacter = CheckWin.True(currentBoard);

                if (playerCharacter != 'N')
                {
                    break; // Break out! Someone has won!
                }
            }

            // Game finished!

            string result = playerCharacter == 'X' ? $"{player1} have" : $"{player2} has";
            Console.WriteLine($"{result} won!");

        }
    }    
}
