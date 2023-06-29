namespace IterationStatements
{
    public class Program
    {

        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void PrintNumbers()
        {
        for(int i = 1000; i <= -1000; i--)
            {
            Console.WriteLine(i);
            
    }

}

//Write a method that will print to the console numbers 3 through 999 by 3 each time
public static void PrintNumbersBy3()
{
    for (int i = 3; i <= 999; i += 3)
    {
        Console.WriteLine(i);
    }
}
//Write a method to accept two integers as parameterss and check whether they are equal or not
public static void AreTheyEqual(int num1, int num2)
{
    if (num1 == num2)
    {
        Console.WriteLine($"{num1} is equal to {num2}");
    }
    else
    {
        Console.WriteLine($"{num1} is not equal to {num2}");
    }
}

//Write a method to check whether a given number is even or odd
public static void EvenOrOdd(int num)
{
    if (num % 2 == 0)
    {
        Console.WriteLine($"{num} is even");
    }
    else
    {
        Console.WriteLine($"{num} is odd");
    }
}
//Write a method to check whether a given number is positive or negative
public static void PositiveOrNegative(int num1)
{
    if (num1 < 0)
    {
        Console.WriteLine($"{num1} is negative");
    }
    else
    {
        Console.WriteLine($"{num1} is positive");
    }
}
//Write a method to read the age of a candidate and determine whether they can vote.
//Hint: Use Parse or the safer TryParse() for an extra challenge
//Parse()
//TryParse()
public static void CheckAge()
{
    Console.WriteLine("What is your age? So you can vote: ");
    bool validNumber = int.TryParse(Console.ReadLine(), out int age);
    if (age >= 18)
    {
        Console.WriteLine("You can vote.");
    }
    else
    {
        Console.WriteLine("you can't vote.");
    }

}
//Heatin Up Section:
//Write a method to check if an integer(from the user) is in the range -10 to 10
public static void InRange()
{
    Console.WriteLine("Enter a number to know if is in range: ");
    int number = int.Parse(Console.ReadLine());

    if (number <= 10 && number >= 10)
    {
        Console.WriteLine("The number is in range");
    }
    else
    {
        Console.WriteLine("The number is out of range");
    }
}
//Write a method to display the multiplication table(from 1 to 12) of a given integer
public static void MultiplicationTable(int num1)
{

    for (int i = 1; i <= 12; i++)
    {
        Console.WriteLine($"{i} x {num1} = {i * num1}");
    }
}
//Call the methods to test them in the Main method below
static void Main(string[] args)
{
    PrintNumbers();
    PrintNumbersBy3();
    AreTheyEqual(5, 6);
    EvenOrOdd(7);
    PositiveOrNegative(9);
    CheckAge();
    InRange();
    MultiplicationTable(12);
}
    }
}
