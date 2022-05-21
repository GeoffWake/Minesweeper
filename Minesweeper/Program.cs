using System;

namespace introduction
{
    class Program
    {
        static void Main(string[] args)
        {





            int[,] grid =
            {
            { 0,0,0,0,0,0,0,0,0,0},
            { 0,0,0,0,0,0,0,0,0,0},
            { 0,0,0,0,0,0,0,0,0,0},
            { 0,0,0,0,0,0,0,0,0,0},
            { 0,0,0,0,0,0,0,0,0,0},
            { 0,0,0,0,0,0,0,0,0,0},
            { 0,0,0,0,0,0,0,0,0,0},
            { 0,0,0,0,0,0,0,0,0,0},
            { 0,0,0,0,0,0,0,0,0,0},
            { 0,0,0,0,0,0,0,0,0,0},
        };

            ///Loop within a loop to display grid to console


            for (int l = 0; l < 10; l++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(grid[l, j] + "\t");
                }
                Console.WriteLine("\n");
            }



            

           
            Random random = new Random();

            int x = 0;
            int y = 0;

            ///Change  ten 0s to 1s for "Bombs"
            for ( int i=0; i < 10; i++)
            {
                x = random.Next(0, 9);
                y = random.Next(0, 9);

                grid[x, y] = 1;
            }


            Console.WriteLine("Line Break");
            Console.WriteLine("Line Break");
            Console.WriteLine("Line Break");



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

           
            
            
                Console.WriteLine("Enter your xy co-ordinates?" );

            for (int i = 0; i < 90; i++)
            {
                guess[i] = Console.ReadLine();
                int j = Int32.Parse(guess[i].Substring(0, 1));
                int k = Int32.Parse(guess[i].Substring(1, 1));

                if (grid[j, k] == 1)
                {
                    Console.WriteLine("Boom");
                } else if (grid[j,k ] != 1)
                {
                    Console.WriteLine("Please try again");
                }

                ////Check surrounding squares

                if (grid[j, k + 1] == 1)
                {
                    bombTracker++;


                }



                
                Console.WriteLine(j);
                Console.WriteLine(k);
                Console.WriteLine(bombTracker);
               





            }


            Console.WriteLine("BreakLine");

                Console.WriteLine(guess);
                

            

        }

    }
}