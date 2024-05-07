
CalculateSumOfNumbersBetween(5, 4);

int CalculateSumOfNumbersBetween(int firstNumber, int lastNumber)
{
    int loopingCondition = firstNumber, sum = 0;
        while (loopingCondition <= lastNumber)
        {
            sum += loopingCondition;
            loopingCondition++;
        }
    return sum;
    
}