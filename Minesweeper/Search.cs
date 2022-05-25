using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    public class Search
    {
        
        //Grid Generator
        public static int[,] GridCreation(int a, int b)
        {
            return new int[a, b];
        }
        int grid = 0;
        //Random Number Generator
        public static int RandomNumberGenerator(int a, int b)
        {
            int x = 0;

            Random random = new Random();
            x = random.Next(a, b);

            return x;



        }
      

        //Check if user input location is a mine or not
        public static void CheckForMine( int [,]grid, int j, int k)
        {

            if (grid[j, k] == 1)
            {
                Console.WriteLine("Boom");
                



            }
            
            else if (grid[j, k] != 1)
            {
                Console.WriteLine("Please try again");
            }

        }

        ///Check Surrounding locations for bombs and tally results
        ///Display "BombTracker" onto Console
        
        public static void CheckSurrounds(int[,] grid, string[,] grid2, int j, int k )

        {
            int bombTracker = 0;



            if (k == 9)
            {

            }
             else if

             ((grid[j, k + 1] == 1)) ///Check Row directly to the right of selected cell
            {
                 bombTracker++;

            }
            if (k == 9 || j == 0)
            {

            }
            else if (grid[j - 1, k + 1] == 1) ///Check Row directly NE/Diagonal right of selected cell  
            {
                 bombTracker++;

            }

            if (k == 0)
            {

            }
            else if (grid[j, k - 1] == 1) ///Check Row directly to the left of selected cell  ///Error when on side of grid
            {
                 bombTracker++;

            }
            if (j == 0)
            {

            }

            else if (grid[j - 1, k] == 1) ///Check Row directly above of selected cell  ///Error when on top of grid
            {
                 bombTracker++;

            }
            if (j == 9)
            {

            }
            else if (grid[j + 1, k] == 1) ///Check Row directly below of selected cell  ///Error when on side of grid
            {
                 bombTracker++;

            }
            if (k == 0 || j == 0)
            {

            }

            else if (grid[j - 1, k - 1] == 1) ///Check Row directly NW/Diagonal left of selected cell  
            {
                 bombTracker++;

            }

            if (k == 0 || j == 9)
            {

            }
            else if (grid[j + 1, k - 1] == 1) ///Check Row directly SW/Diagonal left of selected cell  
            {

                 bombTracker++;

            }

            if (j == 9 || k == 9)
            {

            }
            else if
             ((grid[j + 1, k + 1] == 1)) ///Check Row directly SE/Diagonal right of selected cell  
            {


                 bombTracker++;
               


            }
           
            Console.WriteLine("Position {1},{2} Bombs Around Your Choice:{0} ", bombTracker, k, j);


            ///Second Grid to Display Bomb Tracker 
            string  bomb = bombTracker.ToString();
            grid2[j, k] = bomb;


            
            for (int l = 0; l < 10; l++)
            {
                for (int m = 0; m < 10; m++)
                {
                    Console.Write(grid2[l, m] + "\t");
                }
                Console.WriteLine("\n");
            }


        }   
    }
}
