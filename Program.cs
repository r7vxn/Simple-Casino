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
                    Console.WriteLine("Invalid input, try to give a positive input or an input that is not over your current balance.");
                }
               else
                {
                    
                }
              }
            }
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
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid input, try again.");
            }
        

           
        
           
     
    }
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
    else
    {
        autimunism = true;
        Console.Clear();
        Console.WriteLine("Invalid input you autistic fuck.");
    }
}