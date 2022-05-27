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
            Console.WriteLine("");
            Console.WriteLine("Check a location by entering a number between 0-9 on an XY Axis");
            Console.WriteLine("");
            Console.WriteLine("Example: A guess of 26 represents Column 2 Row 6");
            Console.WriteLine("");
            Console.WriteLine("The Grid below will track your guesses and the amount of mines in corresponding posistions");
            Console.WriteLine("");

            Console.WriteLine("A 2 will mean there are two mines connected with the selected cell");
            Console.WriteLine("A 1 will mean there is one mine connected. An so on...");
            Console.WriteLine("");
            Console.WriteLine("Continue until there are no remaining positions left");
            Console.WriteLine("");
        }

        public static void EndMessage()
        {

           
            Console.WriteLine("Thanks for playing");
            Console.WriteLine("");
            Console.WriteLine("Here were the locations of the mines in your game");
            Console.WriteLine("");
           


        }

        public static void WinnerMessage()
        {
            Console.WriteLine("Congratulations you have been successfull");
        }

        public static void ErrorMessage()
        {
            Console.WriteLine("");
            Console.WriteLine("There has been an error");
            Console.WriteLine("");
        }

        public static void EnterMessage()
        {
            Console.WriteLine("");
            Console.WriteLine("Please Enter your X and Y Co-Ordinate: ");
            
        }

        public static void HitMessage()
        {
            Console.WriteLine("");
            Console.WriteLine("Boom!!!!!!");
            Console.WriteLine("");
            Console.WriteLine("Unfortunetly you have hit a mine");
            Console.WriteLine("");
        }
        public static void NoHitMessage()
        {
            Console.WriteLine("");
            Console.WriteLine("You have successfully missed a mine");
            Console.WriteLine("");
            Console.WriteLine("Please select you next posistion");
            Console.WriteLine("");
        }


    }

}
