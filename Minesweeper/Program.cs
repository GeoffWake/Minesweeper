using System;

namespace Minesweeper
{
    class Program
    {
        static void Main(string[] args)
        {
            /// Grid to see where bombs are render
            int[,] grid = Search.GridCreation(10, 10);

            ///Second Grid
            //int[,]grid2 = Search.GridCreation(10, 10);
            string[,]grid2 = new string[10, 10];
            string star = "*";
            for (int i = 0; i <= 10 - 1; i++)
            {
                for (int h = 0; h <= 10 - 1; h++)
                {
                    grid2[i, h] = star;
                }
            }



            ////Randomly Assign 10 1s to the grid that will represent the "Bombs
            int x = 0;
            int y = 0;
            for (int i = 0; i < 10; i++)
            {
                x = Search.RandomNumberGenerator(0, 10);
                y = Search.RandomNumberGenerator(0, 10);

                grid[x, y] = 1;
 
            }

            Messages.WelcomeMessage();
            Messages.InstructionMessage();
            ////Loop within a loop to display grid to console with Bomb Locations showing 
            ///-NEEDS TO BE REMOVED FOR SUBMISSION

            //for (int l = 0; l < 10; l++)
            //{
            //    for (int j = 0; j < 10; j++)
            //    {
            //        Console.Write(grid[l, j] + "\t");
            //    }
            //    Console.WriteLine("\n");
            //}

            ///Loop through to call Mine check and Surrounds Check
            string[] guess = new string[90];
            for (int i = 0; i < 90; i++)
            {
                try
                {
                Console.WriteLine("Please Enter your X and Y Co-Ordinate: ");
                guess[i] = Console.ReadLine();
                int k = Int32.Parse(guess[i].Substring(0, 1));
                int j = Int32.Parse(guess[i].Substring(1, 1));
               

                ///Check Input Location for Mine
                ///Search.CheckForMine(grid, j, k);
                if (grid[j, k] == 1)
                {
                    Console.WriteLine("Boom");
                    goto EndGame;
                }
                else if (grid[j, k] != 1)
                {
                    Console.WriteLine("Please try again");
                }

                ////Winning Condition
                 if ( i == 90)
                 {
                        Console.WriteLine("Congratulations you are successful");

                 }
                ///Check surrounding locations for Mines and display results on second grid
                Search.CheckSurrounds(grid, grid2, j, k);

                }
                catch
                {
                    Console.WriteLine("There has been an error");
                }
                {
                   /// Console.WriteLine("Please re-enter your X and Y Co-Ordinates");
                }




            }

            EndGame:
            Messages.EndMessage();

        }

    }
}