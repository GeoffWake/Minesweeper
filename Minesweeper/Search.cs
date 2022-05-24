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
        public void CheckForMine(int[,] grid,int j, int k)
        {
            //grid[j, k] = 1;
            for (int i = 0; i < 90; i++)
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
        }


    }
}
