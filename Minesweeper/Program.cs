using System;

namespace Minesweeper
{
    class Program
    {
        static void Main(string[] args)
        {
            /// Grid with bomb locations
            int[,] grid = Search.GridCreation(10, 10);
            ///Second Grid that displays grid of astericks for UI
            string[,] grid2 = new string[10, 10];

            ////Randomly Assign 10 1s to the grid that will represent the "Bombs"
            Game.BombGrid(grid, 0, 0);

            ///Un-Comment to see bomb locations at start of game
            //Search.locations(grid);

            Search.UserDisplay(grid2);  
            Messages.WelcomeMessage();
            Messages.InstructionMessage();
          
            ///Loop through user input to call Mine check and Surrounds Check
            string[] guess = new string[91];
            for (int i = 0; i <= 90; i++)
            {
                try
                {
                Messages.EnterMessage();
                guess[i] = Console.ReadLine();
                int k = Int32.Parse(guess[i].Substring(0, 1));
                int j = Int32.Parse(guess[i].Substring(1, 1));

                    ///Check Input Location for Mine
     
                    if (grid[j, k] == 1)
                    {
                        Messages.HitMessage();
                        goto EndGame;
                    }
                    
                    else if (grid[j, k] != 1)
                    {
                        Messages.NoHitMessage();

                    }
                    ///Check surrounding locations for Mines and display results on second grid and Bombtraceker
                    Search.CheckSurrounds(grid, grid2, j, k);
                    }
                    catch
                    {
                    Messages.ErrorMessage();
                    }
                    if (i == 90)
                    {
                    Messages.WinnerMessage();

                    }
            }


            EndGame:
            Messages.EndMessage();
            Search.locations(grid);

        }

    }
}