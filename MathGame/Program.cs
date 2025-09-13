
string greeting = "Hey, this is a calculator!";

if (true)
{
    Console.WriteLine(greeting);

    Console.WriteLine("Write a number");
    int number1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Write another number");
    int number2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("The multiplication of the numbers is: " + (number1 * number2));
}

