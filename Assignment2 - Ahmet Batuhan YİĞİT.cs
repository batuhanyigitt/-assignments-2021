class Program
{
        static void Main(string[] args)
    {
           enum Menustate { Newgame = 1 ,about=2 , Quit=3 }
            static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Yellows;
            Console.ForegroundColor = ConsoleColor.Blue;

            string x1 = " ", x2 = " ", x3 = " ", x4 = " ", x5 = " ", x6 = " ", x7 = " ", x8 = " ", x9 = " ";
            string turn = "X";
            string input;
            int inputNumber = 0;
            int turnNumber = 0;
            Menustate state;
            Console.WriteLine("THIS IS Tic-Tac-Toe GAME! LET'S START!!");
            Console.WriteLine("=======================");
            Console.WriteLine();
            int i = 0;

            while (true)
            {
                Console.WriteLine("1) New Game");
                Console.WriteLine("2) Author");
                Console.WriteLine("3) Exit");
                while (!Enum.TryParse<Menustate>(Console.ReadKey().KeyChar.ToString(), out state)) ;
                Console.Clear();

              
                if (state == Menustate.Newgame)
                {
                    s1 = " "; s2 = " "; s3 = " "; s4 = " "; s5 = " "; s6 = " "; s7 = " "; s8 = " "; s9 = " ";
                    turn = "X";
                    i = 0;
                    turnnumber = 0;
                    
                    while (i < 9)
                    {
                        Console.WriteLine($" {s1} | {s2} | {s3}");
                        Console.WriteLine("---+---+---");
                        Console.WriteLine($" {s4} | {s5} | {s6}");
                        Console.WriteLine("---+---+---");
                        Console.WriteLine($" {s7} | {s8} | {s9}");

                        if (s1 == s2 && s1 == s3 && s1 != " " ||
                            s4 == s5 && s4 == s6 && s4 != " " ||
                            s7 == s8 && s7 == s9 && s7 != " " ||
                            s1 == s4 && s1 == s7 && s1 != " " ||
                            s2 == s5 && s2 == s8 && s2 != " " ||
                            s3 == s6 && s3 == s9 && s3 != " " ||
                            s1 == s5 && s1 == s9 && s1 != " " ||
                            s3 == s5 && s3 == s7 && s3 != " ")

                {
                        Console.WriteLine($"{turn} has won the game **");
                        Console.WriteLine("Press enter to return menu ");
                        if (Console.ReadKey(true).Key == ConsoleKey.Enter)
                        {
                            Console.Clear();
                            break;
                    }
                           
                }

                if (i % 2 == 0) turn = "X";
                else turn = "O";

                while (turnNumber < 9)
                {
                    Console.Write($"{turn}'s move > ");
                    input = Console.ReadLine();
                    if (!int.TryParse(input, out inputNumber)) continue;

                    switch (inputNumber)
                    {
                        case 1:
                            if (x1 != " ")
                            {
                                Console.WriteLine("This is wrong!! let's try again dude.");
                                continue;
                            }
                            x1 = turn;
                            break;
                        case 2:
                            if (x2 != " ")
                            {
                                Console.WriteLine("This is wrong!! let's try again dude.");
                                continue;
                            }
                            x2 = turn;
                            break;
                        case 3:
                            if (x3 != " ")
                            {
                                Console.WriteLine("This is wrong!! let's try again dude.");
                                continue;
                            }
                            x3 = turn;
                            break;
                        case 4:
                            if (x4 != " ")
                            {
                                Console.WriteLine("This is wrong!! let's try again dude.");
                                continue;
                            }
                            x4 = turn;
                            break;
                        case 5:
                            if (x5 != " ")
                            {
                                Console.WriteLine("This is wrong!! let's try again dude.");
                                continue;
                            }
                            x5 = turn;
                            break;
                        case 6:
                            if (x6 != " ")
                            {
                                Console.WriteLine("This is wrong!! let's try again dude.");
                                continue;
                            }
                            x6 = turn;
                            break;
                        case 7:
                            if (x7 != " ")
                            {
                                Console.WriteLine("This is wrong!! let's try again dude.");
                                continue;
                            }
                            x7 = turn;
                            break;
                        case 8:
                            if (x8 != " ")
                            {
                                Console.WriteLine("This is wrong!! let's try again dude.");
                                continue;
                            }
                            x8 = turn;
                            break;
                        case 9:
                            if (x9 != " ")
                            {
                                Console.WriteLine("This is wrong!! let's try again dude.");
                                continue;
                            }
                                x9 = turn;
                                break;
                            default:
                                Console.WriteLine("This is wrong!! let's try again dude.");
                                continue;
                        }
                        inputNumber = 0;
                        turnNumber++;
                        break;
                        }
                    }
                }
                     
                     
                else if (state == Menustate.about)
                {
                    Console.WriteLine("Coded by Batuhan, 2021. All rights reserved.");
                    Console.WriteLine(" Enter the menu for return to menu ");
                    if (Console.ReadKey(true).Key == ConsoleKey.Enter)
                    {
                        continue;
                    }
                }
            
                else if (state == Menustate.Quit)
                {
                    Console.WriteLine("Do you want to quit the game? Y for exit, any key return to main manu");
                    if (Console.ReadKey(true).Key == ConsoleKey.Y)
                    {
                        return;
                    }
                }
            }
        }
    }
