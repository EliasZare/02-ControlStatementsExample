//*** Control Statement ***

NestedFor();

Console.WriteLine("\n\n\n\n");
Console.WriteLine("----- Welcome ----", Console.ForegroundColor = ConsoleColor.White);
do
{
    Console.WriteLine("*** Control Statement *** ", Console.ForegroundColor = ConsoleColor.Green);
    Console.WriteLine("\n1-Condition control statement (Enter 1)", Console.ForegroundColor = ConsoleColor.White);
    Console.WriteLine("2-Looping control statement (Enter 2)");
    Console.WriteLine("3-Jumping control statement (Enter 3");
    Console.WriteLine("4-Odd or Even (Enter 4");
    Console.WriteLine("5-Nested For (Enter 5");
    Console.WriteLine("6-Exit (Enter 6)");
    Console.Write("Enter ur choice: ");
    var num = Console.ReadLine();
    switch (num)
    {
        case "1":
            ConditionControlStatement();
            break;
        case "2":
            LoopingControlStatement();
            break;
        case "3":
            JumpingControlStatement();
            break;
        case "4":
            Console.WriteLine("Enter a number");
            var number = int.Parse(Console.ReadLine());
            Console.WriteLine(OddOrEven(number));
            break;
        case "5":
            NestedFor();
            break;
        case "6":
            Console.Clear();
            break;
        default:
            Console.WriteLine("Not found!");
            break;
    }
} while (true);

Console.ReadKey();


void ConditionControlStatement()
{
    // Condition control statement
    // If / If-else / else-if / Switch

    // Simple if :
    if (true) Console.WriteLine("True!");

    //if-else

    if (false)
        Console.WriteLine("true");
    Console.WriteLine("false => else block");

    //else -if

    if (false)
        Console.WriteLine("true");
    if (false)
        Console.WriteLine("else block1");
    if (true) Console.WriteLine("True => else block 2");


    Console.WriteLine("-------------------------", Console.ForegroundColor = ConsoleColor.Green);
}

void LoopingControlStatement()
{
    // Looping control statement
    // While / do-while / for
}

void JumpingControlStatement()
{
    // Jumping control statement
    // break / continue
    Console.WriteLine("*** Break ***");

    for (var i = 0; ; i++)
    {
        if (i == 6) break;
        Console.WriteLine(i);
    }

    Console.WriteLine("*** Continue ***");
    for (var i = 0; i < 10; i++)
    {
        if (i == 6) continue;
        Console.WriteLine(i);
    }
}

string OddOrEven(int number)
{

    if (number % 2 == 1)
        return number + " is Odd";
    return number + " is Even";

}

// Nested for

void NestedFor()
{
   for(int i=1;i<10; i++)
    {
        Console.WriteLine();
        for (int j=10;j>i; j--)
        {
            Console.Write("*");
        }

    }
    for (int i = 1; i < 10; i++)
    {
        Console.WriteLine();
        for (int j = 0; j < i; j++)
        {
            Console.Write("*");
        }

    }
    Console.WriteLine("\n");
}