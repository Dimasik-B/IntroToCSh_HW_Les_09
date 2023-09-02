Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
Console.WriteLine(NaturalNumbersBackwards(1, number));

string NaturalNumbersBackwards(int firstNumber, int lastNmber)
{
    if (lastNmber == firstNumber) return firstNumber.ToString();
    return (lastNmber + ", " + NaturalNumbersBackwards(firstNumber, lastNmber - firstNumber).ToString());
}