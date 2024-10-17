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
            
            /* MAIN GAME LOOP
             
             TODO - User interface?
             TODO - Clear output in console after every move.
             TODO - Thread.Sleep(~3000) när datorn "gör sitt drag"
             
             
             
             */
            //while (true)
            //{
            //    Console.WriteLine("What's your next move? (1-9)");
            //    bool validMove;
            //    do
            //    {
            //        validMove = int.TryParse(Console.ReadLine(), out int userPositionChoice);
            //        if (userPositionChoice)
            //    } while (validMove);
            //}

        }
    }    
}
