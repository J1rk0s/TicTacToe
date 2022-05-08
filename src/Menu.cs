using System;

namespace TicTacToeConsole
{
    public class Menu
    {
        public static void menu()
        {
            Console.WriteLine("1) 3x3\n" +
                              "2) 6x6\n" +
                              "3) 9x9\n" +
                              "4) 12x12\n");
            Console.Write("Enter field size: ");
            string option = Console.ReadLine();
        }
    }
}