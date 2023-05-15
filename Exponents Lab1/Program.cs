using System.Net.Http.Headers;

bool goAgain = true;

do
{
    begin:  Console.Write("Please enter an integer: ");

    
    double input = Convert.ToDouble(Console.ReadLine());
    double squared = Math.Pow(input, 2);
    double cubed = input * input * input;

    Console.WriteLine($"Number          Squared        Cubed ");
    Console.WriteLine($"=====           =======        ======");
    
    Console.WriteLine(string.Format($"{input, -15} {squared, -15} {cubed, -25}"));

    Console.Write("Keep Going? Enter (y/n) ");
     string keepGoing = Console.ReadLine().ToLower();
    if (keepGoing == "y")
    {
        goto begin;
    }
    goAgain = false;
    
}while(goAgain);