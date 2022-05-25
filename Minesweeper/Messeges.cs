using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    internal class Messages
    {
        public static void WelcomeMessage()
        {
            Console.WriteLine("******Welcome to Mine Sweeper*****");
            Console.WriteLine("");
            Console.WriteLine("");
        }

        public static void InstructionMessage()
        {
            Console.WriteLine("Win the game by successfully revealing all locations that do not contain a bomb");
            Console.WriteLine("Check a location by entering a number between 0-9");
            Console.WriteLine("for the x-axis or columns and for the y-axis or rows");
            Console.WriteLine("The Grid below will track your guesses and the amount of mines in corresponding posistions");
            Console.WriteLine("A 2 will mean there are two mines connected with the selected cell");
            Console.WriteLine("A 1 will mean there is one mine connected.");
            Console.WriteLine("A 0 will mean there are no mines connected to your choice");
            Console.WriteLine("Continue until there re no remaining positions left");
        }

        public static void EndMessage()
        {
            Console.WriteLine("Unfortunently you hit a mine" );
            Console.WriteLine("Please try again");

        }

        public static void WinnerMessage()
        {
            Console.WriteLine("Congratulations you have successfully missed all mines");
        }
    }

}
