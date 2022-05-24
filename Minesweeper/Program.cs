using System;

namespace Minesweeper
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Create Grid
            int[,] grid = Search.GridCreation(10, 10);

            ///Second Grid
            int[,]grid2 = Search.GridCreation(10, 10);



            ////Randomly Assign 10 1s to the grid that will represent the "Bombs"
            ///

            int x = 0;
            int y = 0;
            for (int i = 0; i < 10; i++)
            {
                x = Search.RandomNumberGenerator(0, 10);
                y = Search.RandomNumberGenerator(0, 10);

                grid[x, y] = 1;

            }


            ////Loop within a loop to display grid to console with Bomb Locations showing 
            ///-NEEDS TO BE REMOVED FOR SUBMISSION

            for (int l = 0; l < 10; l++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(grid[l, j] + "\t");
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("Enter your XY co-ordinates?");


            ///Loop through to call Mine check and Surrounds Check
             string[] guess = new string[90];
            for (int i = 0; i < 90; i++)
            {

                    guess[i] = Console.ReadLine();
                   int k = Int32.Parse(guess[i].Substring(0, 1));
                   int  j= Int32.Parse(guess[i].Substring(1, 1));


                Console.WriteLine("Information displayed below will track your guesses and the amount of mines in corresponding posistions");
                Console.WriteLine("A 2 will mean there are two mines connected with the selected cell");
                Console.WriteLine("A 1 will mean there is one mine connected.");
                Console.WriteLine("A 0 will mean there are no mines connected to your choice");
                Console.WriteLine("Continue with your guess until there re no remaining squares");


                Search.CheckForMine(grid, j, k);

                Search.CheckSurrounds(grid, grid2, j, k);



                //    ///Show second Grid that tracks users guesses with a 3
                //    grid2[j, k] = 3;


                //    for (int l = 0; l < 10; l++)
                //{
                //    for (int m = 0; m < 10; m++)
                //    {
                //        Console.Write(grid2[l, m] + "\t");
                //    }
                //    Console.WriteLine("\n");
                //}

            }

        }

    }
}