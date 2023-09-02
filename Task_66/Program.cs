Console.Write("Введите число: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Cумма натуральных элементов в промежутке от {m} до {n} равна {NaturalNumbersSum(m, n)}");

int NaturalNumbersSum(int firstNumber, int lastNmber)
{
    if (firstNumber == lastNmber) return lastNmber;
    if (firstNumber < lastNmber) return (firstNumber += NaturalNumbersSum(firstNumber + 1, lastNmber));
    return (lastNmber += NaturalNumbersSum(firstNumber, lastNmber + 1));
}