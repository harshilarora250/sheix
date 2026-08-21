Console.WriteLine("Hello User! Welcome to Sheix!");

// Basic Operation detection program..

while (true)
{
string operation = Console.ReadLine();

if (operation=="+")
{
    Console.WriteLine("You chose addition! (+)");
}

if (operation == "-")
{
    Console.WriteLine("You chose subtraction! (-)");
}

if (operation == "/")
{
    Console.WriteLine("You chose division! (/)");
}

if (operation == "*")
{
    Console.WriteLine("You chose multiplication! (*)");
}
}