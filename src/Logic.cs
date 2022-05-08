using System;
using System.Collections.Generic;
using System.Linq;

namespace TicTacToeConsole {
    public class Logic {

        public static void ShowField(int fieldSize) {
            switch (fieldSize) {
                case 3:
                    Field3X3();
                    break;
                case 6:
                    break;
                case 9:
                    break;
                case 12:
                    break;
            }
        }

        private static void Field3X3() {
            string[] field = new string[9];
            bool PWon = false;
            while(!PWon) {
                PWon = P1Checker(field);
                Console.WriteLine("\n" +
                                  $"{field[0]} | {field[1]} | {field[2]}\n" +
                                  $"{field[3]} | {field[4]} | {field[5]}\n" +
                                  $"{field[6]} | {field[7]} | {field[8]}\n");
                Player1:
                    Console.WriteLine("Enter field name player1(1 - 9): ");
                    int fieldNameP1 = Convert.ToInt32(Console.ReadLine());
                    fieldNameP1 -= 1;
                    if (field[fieldNameP1] == null) {
                        field[fieldNameP1] = "X";
                    }
                    else if (field[fieldNameP1] != null || fieldNameP1 > 8) {
                        Console.WriteLine("Invalid option! please try again!");
                        goto Player1;
                    }
                    Console.WriteLine("\n" +
                                      $"{field[0]} | {field[1]} | {field[2]}\n" +
                                      $"{field[3]} | {field[4]} | {field[5]}\n" +
                                      $"{field[6]} | {field[7]} | {field[8]}\n");
                    PWon = P1Checker(field);
                Player2:
                    Console.WriteLine("Enter field name player2(1 - 9): ");
                    int fieldNameP2 = Convert.ToInt32(Console.ReadLine());
                    fieldNameP2 -= 1;
                    if (field[fieldNameP2] == null) {
                        field[fieldNameP2] = "O";
                    }
                    else if (field[fieldNameP2] != null || fieldNameP2 > 8) {
                        Console.WriteLine("Invalid option! please try again!");
                        goto Player2;
                    }
                    PWon = P1Checker(field);
            }
            P1Won:
                Console.WriteLine("Player 1 won!");
            P2Won:
                Console.WriteLine("Player 2 won!");
        }

        private static bool P1Checker(string[] field) {
            int[] index = field.Select((b,i) => b == "X" ? i : -1).Where(i => i != -1).ToArray();
            if (index.Contains(0) && index.Contains(1) && index.Contains(2)) {
                return true;
            }
            return false;
        }
    }
}