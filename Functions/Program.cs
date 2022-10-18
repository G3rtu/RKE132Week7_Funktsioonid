Console.WriteLine("Are you coming or leaving? (in/out):");
string userChoise = Console.ReadLine();

if(userChoise == "in")
{
    PrintHello();
}
else
{
    PrintGoodgye();
}



//PrintHello();
//PrintGoodgye();


static void PrintHello()
{
    Console.WriteLine("Hello, world!");
}
static void PrintGoodgye()
{
    Console.WriteLine("See you later, aligator!");
}