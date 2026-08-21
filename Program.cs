Console.WriteLine("Hello User! Welcome to Sheix!");

// Basic Operation detection program..

while (true)
{
string operation = Console.ReadLine();

if (operation == "")
{
    Console.WriteLine("Please enter an operation :)");
}

else if (operation=="+")
{
    Console.WriteLine("You chose addition! (+)");
}

else if (operation == "-")
{
    Console.WriteLine("You chose subtraction! (-)");
}

else if (operation == "/")
{
    Console.WriteLine("You chose division! (/)");
}

else if (operation == "*")
{
    Console.WriteLine("You chose multiplication! (*)");
}
else if (operation == "!")
{
    Console.WriteLine("!! Pretty sure that isn't a Math Operation, try again :)");
}
else 
{
    Console.WriteLine("Invalid operation, please try with the following options: (+,-,*,/)");
}
}