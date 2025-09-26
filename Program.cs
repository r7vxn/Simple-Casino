bool done;

done = false;

string project;

bool autimunism = false;

double money = 100;

string fliporquit;

int coinflip;

string headortail;

double bet;

string coinoutput;

double won;

double moneywon;

double moneyloss;

Random generator;
generator = new Random();

//loop
while (!done)
{
    //menu
    Console.WriteLine(@"
    1. Continue Game
    2. Quit
    ");


    project = Console.ReadLine();

    //gambling
    if (project == "1" && money != 0)
    {

        Console.WriteLine($"You currently own {money.ToString("c")} do you wanna flip or quit. (Enter \"Flip\" / \"Quit\")");

        fliporquit = Console.ReadLine().ToLower();

        if (fliporquit == "flip")
        {
            Console.WriteLine("Head or Tail (enter \"H\" or \"T\")");
            headortail = Console.ReadLine().ToLower();
            coinflip = generator.Next(2);

            if (headortail == "h")
            {
                Console.WriteLine($"How much do you want to bet, you currently own {money.ToString("c")} (Enter numbers, ex. 100)");
                double.TryParse(Console.ReadLine(), out bet);
                if (bet <= 0 || bet > money)
                {
                    Console.Clear();
                    Console.WriteLine("Invalid input, try to give a positive input or an input that is not over your current balance.");
                }
                else
                {
                    if (coinflip == 0)
                    {
                        Console.WriteLine("Congrats, head, you won!");
                        won = bet * 1.5;
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
                        Console.Clear() ;
                    }
                }
            }
            else if (headortail == "t")
            {
                Console.WriteLine($"How much do you want to bet, you currently own {money.ToString("c")} (Enter numbers, ex. 100)");
                double.TryParse(Console.ReadLine(), out bet);
                if (bet <= 0 || bet > money)
                {
                    Console.Clear();
                    Console.WriteLine("Invalid input, try to give a positive input or an input that is not over your current balance.");
                }
                else
                {
                    if (coinflip == 0)
                    {
                        Console.WriteLine("Congrats, tails, you won!");
                        won = bet * 1.5;
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
           
        }
        //quit
        else if (fliporquit == "quit")
        {

            if (autimunism == true)
            {
                Console.WriteLine("Thank you for playing you autistic fuck");
            }
            else
            {
                Console.WriteLine("Was a pleasure to have you play here mate, see you sometime again soon!");
            }
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
        if (autimunism == true)
        {
            Console.WriteLine("Thank you for playing you autistic fuck");
        }
        else
        {
            Console.WriteLine("Was a pleasure to have you play here mate, see you sometime again soon!");
        }
        done = true;
    }
    //if brankrupt
    else if (money == 0)
    {
        Console.WriteLine("Your officially broke now, you got no money to bet.");
        if (autimunism == true)
        {
            Console.WriteLine("Thank you for playing you autistic fuck");
        }
        else
        {
            Console.WriteLine("Was a pleasure to have you play here mate, see you sometime again soon!");
        }
        done = true;
    }
    //invalid input in menu
    else
    {
        autimunism = true;
        Console.Clear();
        Console.WriteLine("Invalid input you autistic fuck.");
    }
}