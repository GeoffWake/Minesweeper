using System;

namespace Minesweeper
{
    class Program
    {
        static void Main(string[] args)
        {





            ///Create Grid
            int[,] grid= Search.GridCreation(10, 10);

            


            ////Randomly Assign 10 1s to the grid that will represent the "Bombs"
            ///

            int x = 0;
            int y = 0;
            for (int i = 0; i < 10; i++)
            {
               x= Search.RandomNumberGenerator(0,10);
               y= Search.RandomNumberGenerator(0, 10);

                 grid[x, y] = 1;    

            }

          
           

            ///Loop within a loop to display grid to console with Bomb Locations showing -NEEDS TO BE REMOVED FOR SUBMISSION

            for (int l = 0; l < 10; l++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(grid[l, j] + "\t");
                }
                Console.WriteLine("\n");
            }


            string[] guess = new string[90];

            ///Track Bombs in surrounding squares
            int bombTracker = 0;

            


            Console.WriteLine("Enter your XY co-ordinates?");

            for (int i = 0; i < 90; i++)
            {
                guess[i] = Console.ReadLine();
                int k = Int32.Parse(guess[i].Substring(0, 1));
                int  j= Int32.Parse(guess[i].Substring(1, 1));


                if (grid[j,k ] == 1)
                {
                    Console.WriteLine("Boom");
                }
                else if (grid[j, k] != 1)
                {
                    Console.WriteLine("Please try again");
                }

                
                
                if (k == 9)
                {

                } else if
                    
                    ((grid[j, k + 1] == 1)) ///Check Row directly to the right of selected cell
                {
                    bombTracker++;

                }
                if (k == 9 || j==0)
                {

                }    
                    else if (grid[j - 1, k + 1] == 1) ///Check Row directly NE/Diagonal right of selected cell  
                {
                    bombTracker++;

                }

                if (k==0)
                {

                }
                 else if (grid[j, k - 1] == 1) ///Check Row directly to the left of selected cell  ///Error when on side of grid
                {
                    bombTracker++;

                }
                if (j==0)
                {

                }
                 
                else if (grid[j - 1, k] == 1) ///Check Row directly above of selected cell  ///Error when on top of grid
                {
                    bombTracker++;

                } 
                if ( j == 9)
                {

                }
                else if (grid[j + 1, k] == 1) ///Check Row directly below of selected cell  ///Error when on side of grid
                {
                    bombTracker++;

                } 
                if (k==0 || j==0)
                {

                }

                else  if (grid[j - 1, k - 1] == 1) ///Check Row directly NW/Diagonal left of selected cell  
                {
                    bombTracker++;

                }
                
                if (k== 0 || j == 9)
                {

                }
                else if (grid[j + 1, k - 1] == 1) ///Check Row directly SW/Diagonal left of selected cell  
                {
                    bombTracker++;

                }

                if (j == 9 || k ==9)
                {

                }
                else if
                 ((grid[j + 1, k + 1] == 1)) ///Check Row directly SE/Diagonal right of selected cell  
                {
                    bombTracker++;
                    
                }

                ///Show second Grid that displays number 3 for no bomb areas
                //grid2[j, k] = 3;

               
            //for (int l = 0; l < 10; l++)
            //{
            //    for (int m = 0; m < 10; m++)
            //    {
            //        Console.Write(grid2[l, m] + "\t");
            //    }
            //    Console.WriteLine("\n");
            //}



                 
               // Console.WriteLine(k);
               // Console.WriteLine(j);
                Console.WriteLine("Position {1},{2} BombTracker Count:{0} ",bombTracker, k, j);

                //Console.WriteLine(bombTracker);
                bombTracker = 0;






                




            }


        }

    }
}