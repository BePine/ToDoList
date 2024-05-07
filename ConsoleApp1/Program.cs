Factorial(5);

int Factorial(int number)
{
    int factorial = 1;
    for (int i = 1; i <= number; i++)
    {
        factorial = factorial * i;
        Console.WriteLine(factorial);

    }//your code goes here
    Console.WriteLine(factorial);
    return factorial;
}
Console.ReadKey();
