bool done;

done = false;

string project;

bool autimunism = false;

double money = 100;

bool flip;

bool errorloop = true;

Random generator;
generator = new Random();

while (!done)
{
    Console.WriteLine(@"
    1. Continue Game
    2. Quit
    ");

    project = Console.ReadLine();

    if (project == "1")
    {
        while (errorloop)
        {
            Console.WriteLine($"You currently own {money.ToString("c")} do you wanna flip or quit. (Enter \"Flip\" / \"Quit\")");

            if (Console.ReadLine().ToLower() == "flip")
            {
                flip = true;
                errorloop = false;
            }
            else if (Console.ReadLine().ToLower() == "quit")
            {
                flip = false;
                errorloop = false;
            }
            else
            {
                Console.WriteLine("Invalid input, try again.");
            }
        }

       
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
        else
        {







        }
    }
    if (project == "2")
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
    else
    {
        autimunism = true;
        Console.Clear();
        Console.WriteLine("Invalid input you autistic fuck.");
    }
}