
int[,] arrayNew = { { 2024, 433464366, 0 }, { -5520, 556, -8 } };
int result = FindMax(arrayNew);
Console.WriteLine(result);
Console.ReadKey();
int FindMax(int[,] numbers)
{
    if (numbers.GetLength(0) != 0 && numbers.GetLength(1) != 0)
    {
        int maximalNumber = numbers[0, 0];
        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            for (int j = 0; j < numbers.GetLength(1); j++)
            {
                if (numbers[i, j] > maximalNumber)
                {
                    maximalNumber = numbers[i, j];
                }
            }
        }
        return maximalNumber;
    }
    else
    {
        return -1;
    }
    //your code goes here
}