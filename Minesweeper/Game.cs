using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    internal class Game
    {
        public static void BombGrid(int[,]grid , int x, int y)
        {
            
            for (int i = 0; i < 10; i++)
            {
                x = Search.RandomNumberGenerator(0, 10);
                y = Search.RandomNumberGenerator(0, 10);

                grid[x, y] = 1;

            }
        }


    }
}
