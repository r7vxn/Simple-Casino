bool done;

done = false;

string project;

double money = 100;

string fliporquit = "";

int coinflip;

string headortail = "";

double bet = 0;

double won;

double moneywon;

double moneyloss;

bool hort = false;

bool betloop = false;

bool forq = false;

Random generator;
generator = new Random();

//loop
while (!done)
{
    //menu
    Console.WriteLine(@"
Welcome to MY casino, if you need more money, just ask Yusuf >:D
    1. Continue to Casino
    2. Leave
    3. Ask Yusuf for money
    ");


    project = Console.ReadLine();

    //gambling
    if (project == "1" && money != 0)
    {
        //flip or quit error loop
        forq = false;
        while (!forq)
        {
            Console.WriteLine($"You currently own {money.ToString("c")} do you wanna flip or quit. (Enter \"Flip\" / \"Quit\")");

            fliporquit = Console.ReadLine().ToLower();
            if (fliporquit != "flip" && fliporquit != "quit")
            {
                Console.Clear();
                Console.WriteLine("Invalid input, do better next time.");
            }
            else
            {
                forq = true;
            }

        }
        if (fliporquit == "flip")
        {
            //heads or tail error loop
            hort = false;
            while (!hort)
            {
                Console.WriteLine("Head or Tail (enter \"H\" or \"T\")");
                headortail = Console.ReadLine().ToLower();
                if (headortail == "h" || headortail == "t" || headortail == "heads" || headortail == "tails")
                {
                    hort = true;
                    betloop = false;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Invalid input gang, how'd you mess this up, c'mon...");
                }
            }
            //bet error loop
            while (betloop == false)
            {
                Console.WriteLine($"How much do you want to bet, you currently own {money.ToString("c")} (Enter numbers, ex. 100)");
                while (!double.TryParse(Console.ReadLine(), out bet))
                {
                    Console.Clear();
                    Console.WriteLine("Invalid input, try again");
                    Console.WriteLine($"How much do you want to bet, you currently own {money.ToString("c")} (Enter numbers, ex. 100)");
                }
                if (bet <= 0 || bet > money)
                {
                    Console.Clear();
                    Console.WriteLine("Invalid input, try to give a positive input or an input that is not over your current balance.");

                }
                else
                {
                    betloop = true;
                }

            }
            //actual gambling if head
            coinflip = generator.Next(2);
            if (headortail == "h" || headortail == "heads")
            {
                if (coinflip == 0)
                {
                    Console.WriteLine("Congrats, head, you won!");
                    won = bet;
                    moneywon = won + money;
                    money = moneywon;
                    Console.WriteLine($"You won {won.ToString("c")}!");
                    Console.WriteLine($"You currently own {moneywon.ToString("c")}");
                    Console.WriteLine("Press ENTER to continue");
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (coinflip == 1)
                {
                    moneyloss = money - bet;
                    money = moneyloss;
                    Console.WriteLine("Too bad too sad you lost (LMFAO)");
                    Console.WriteLine($"You lost {bet.ToString("c")}, skill issue LMAO.");
                    Console.WriteLine($"You currently own {moneyloss.ToString("c")}");
                    Console.WriteLine("Press ENTER to continue");
                    Console.ReadLine();
                    Console.Clear();
                }

            }
            //actual gambling if tail
            else if (headortail == "t" || headortail == "tails")
            {
                if (coinflip == 0)
                {
                    Console.WriteLine("Congrats, tails, you won!");
                    won = bet;
                    moneywon = won + money;
                    money = moneywon;
                    Console.WriteLine($"You won {won.ToString("c")}!");
                    Console.WriteLine($"You currently own {moneywon.ToString("c")}");
                    Console.WriteLine("Press ENTER to continue");
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (coinflip == 1)
                {
                    moneyloss = money - bet;
                    money = moneyloss;
                    Console.WriteLine("Too bad too sad you lost (LMFAO)");
                    Console.WriteLine($"You lost {bet.ToString("c")}, skill issue LMAO.");
                    Console.WriteLine($"You currently own {moneyloss.ToString("c")}");
                    Console.WriteLine("Press ENTER to continue");
                    Console.ReadLine();
                    Console.Clear();
                }
            }

        }
        //quit
        else if (fliporquit == "quit")
        {
            Console.WriteLine("Was a pleasure to have you play here mate, see you sometime again soon!");

            done = true;
        }
        //error message for flip or quit
        else
        {
            Console.Clear();
            Console.WriteLine("Invalid input, try again.");
        }
    }
    //quit in main menu
    else if (project == "2")
    {
        Console.WriteLine("Was a pleasure to have you play here mate, see you sometime again soon!");

        done = true;
    }
    //Secret easter egg
    else if (project == "3")
    {
        Console.WriteLine("Hello, I'm Yusuf. You really thought I would give you money?! LMAO, pathetic mortal. WAIT WHAT?! BADDIE!? WHERE!?");
        Console.WriteLine("*money + 1000*");
        money = money + 1000;
        Console.WriteLine("Don't forget the number you promised O.o");
        Console.WriteLine("Press ENTER to continue");
        Console.ReadLine();
        Console.Clear();

    }
    //if brankrupt
    else if (money == 0)
    {
        Console.WriteLine("Your officially broke now, you got no money to bet.");

        Console.WriteLine("Was a pleasure to have you play here mate, see you sometime again soon!");

        done = true;
    }
    //invalid input in menu
    else
    {
        Console.Clear();
        Console.WriteLine("Invalid input dude, get better...");
    }
}