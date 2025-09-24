bool done;

done = false;

string project;

bool autimunism = false;

while (!done)
{
    Console.WriteLine(@"
    1. Continue Game
    2. Quit
    ");

    project = Console.ReadLine();

    if (project == "1")
    {




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