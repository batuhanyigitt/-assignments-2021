using System;

namespace assignment_5
{

    static class Settings
    {

        static public void GameTable(
        string x1, string x2, string x3,
        string x4, string x5, string x6,
        string x7, string x8, string x9)
        {
            Console.Clear();
            Console.WriteLine($" {x1} | {x2} | {x3}");
            Console.WriteLine("---+---+---");
            Console.WriteLine($" {x4} | {x5} | {x6}");
            Console.WriteLine("---+---+---");
            Console.WriteLine($" {x7} | {x8} | {x9}");
        }

        static public void WrongMove()
        {
            Console.WriteLine("Wrong move!");
        }

        static public void Welcome()
        {
            Console.Clear();
            Console.WriteLine("Welcome to Tic-Tac-Toe!");
        }

        static public void Menu()
        {
            Console.Clear();
            Console.WriteLine("1. New Game");
            Console.WriteLine("2. About the author");
            Console.WriteLine("3. Exit");
        }

        static public void AboutMenu()
        {
            Console.Clear();
            Console.WriteLine("Powered by Ahmet Batuhan Yiğit / 2022");
        }

        static public void PressAnyKey()
        {
            Console.WriteLine("Press any key for the return menu");
            Console.ReadKey();
        }

        static public void ExitGame()
        {
            Console.Clear();
            Console.WriteLine("Are you sure for the close game? Press ESC");
        }

        static public void Winner(string turn)
        {
            Console.WriteLine($"{turn} is the winner!");
        }

        static public void Turn(string turn)
        {
            Console.Write($"{turn}'s move > ");
        }
    }

    class Game
    {
        static string x1 = " ", x2 = " ", x3 = " ", x4 = " ", x5 = " ", x6 = " ", x7 = " ", x8 = " ", x9 = " ";
        static void Main(string[] args)
        {
            string turn = "X";
            string input;
            int inputNumber = 0;
            int turnNumber = 0;
            string menuInput = "";

            Settings.Welcome();
            while (true)
            {
                Settings.Menu();
                menuInput = Console.ReadLine();

                if (menuInput == "1")
                {
                    turnNumber = 0;
                    x1 = " "; x2 = " "; x3 = " "; x4 = " "; x5 = " "; x6 = " "; x7 = " "; x8 = " "; x9 = " ";
                    Settings.GameTable(x1, x2, x3, x4, x5, x6, x7, x8, x9);

                    while (turnNumber < 9)
                    {
                        Settings.GameTable(x1, x2, x3, x4, x5, x6, x7, x8, x9);

                        if (turnNumber % 2 == 0) turn = "X";
                        else turn = "O";
                        Settings.Turn(turn);
                        input = Console.ReadLine();

                        if (!int.TryParse(input, out inputNumber))
                        {
                            Settings.WrongMove();
                            continue;
                        };

                        switch (inputNumber)
                        {
                            case 1:
                                if (x1 != " ")
                                {
                                    continue;
                                }
                                x1 = turn;
                                turnNumber++;
                                break;
                            case 2:
                                if (x2 != " ")
                                {
                                    Settings.WrongMove();
                                    continue;
                                }
                                x2 = turn;
                                turnNumber++;
                                break;
                            case 3:
                                if (x3 != " ")
                                {
                                    Settings.WrongMove();
                                    continue;
                                }
                                x3 = turn;
                                turnNumber++;
                                break;
                            case 4:
                                if (x4 != " ")
                                {
                                    Settings.WrongMove();
                                    continue;
                                }
                                x4 = turn;
                                turnNumber++;
                                break;
                            case 5:
                                if (x5 != " ")
                                {
                                    Settings.WrongMove();
                                    continue;
                                }
                                x5 = turn;
                                turnNumber++;
                                break;
                            case 6:
                                if (x6 != " ")
                                {
                                    Settings.WrongMove();
                                    continue;
                                }
                                x6 = turn;
                                turnNumber++;
                                break;
                            case 7:
                                if (x7 != " ")
                                {
                                    Settings.WrongMove();
                                    continue;
                                }
                                x7 = turn;
                                turnNumber++;
                                break;
                            case 8:
                                if (x8 != " ")
                                {
                                    Settings.WrongMove();
                                    continue;
                                }
                                x8 = turn;
                                turnNumber++;
                                break;
                            case 9:
                                if (x9 != " ")
                                {
                                    Settings.WrongMove();
                                    continue;
                                }
                                x9 = turn;
                                turnNumber++;
                                break;
                            default:
                                Settings.WrongMove();
                                break;


                        }

                        if (x1 == x2 && x1 == x3 && x1 != " " ||
                                 x4 == x5 && x4 == x6 && x4 != " " ||
                                 x7 == x8 && x7 == x9 && x7 != " " ||
                                 x1 == x4 && x1 == x7 && x1 != " " ||
                                 x2 == x5 && x2 == x8 && x2 != " " ||
                                 x3 == x6 && x3 == x9 && x3 != " " ||
                                 x1 == x5 && x1 == x9 && x1 != " " ||
                                 x3 == x5 && x3 == x7 && x3 != " ")
                        {
                            Settings.GameTable(x1, x2, x3, x4, x5, x6, x7, x8, x9);
                            Settings.Winner(turn);
                            Settings.PressAnyKey();
                            break;
                        }

                        if (turnNumber == 9)
                        {
                            Settings.GameTable(x1, x2, x3, x4, x5, x6, x7, x8, x9);
                            Console.WriteLine("It is a tie!");
                            Settings.PressAnyKey();
                        }
                    }
                }

                else if (menuInput == "2")
                {
                    Settings.AboutMenu();
                    Settings.PressAnyKey();
                    continue;
                }

                else if (menuInput == "3")
                {
                    Settings.ExitGame();
                    if (Console.ReadKey().Key == ConsoleKey.Escape)

                        return;
                }
            }

        }
    }

}