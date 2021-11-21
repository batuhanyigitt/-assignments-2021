class Program
    {
        static void Main(string[] args)
        {
            string x1 = " ", x2 = " ", x3 = " ", x4 = " ", x5 = " ", x6 = " ", x7 = " ", x8 = " ", x9 = " ";
            string turn = "X";
            string input;
            int inputNumber = 0;
            int turnNumber = 0;
            Console.WriteLine("THIS IS Tic-Tac-Toe GAME! LET'S START!!");

            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine($" {x1} | {x2} | {x3}");
                Console.WriteLine("---+---+---");
                Console.WriteLine($" {x4} | {x5} | {x6}");
                Console.WriteLine("---+---+---");
                Console.WriteLine($" {x7} | {x8} | {x9}");

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

            Console.WriteLine("Game is done!. Want a another game?");
        }
    }