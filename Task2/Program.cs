// // Задача: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// // M = 1; N = 15 -> 120
// // M = 4; N = 8. -> 30

int ReadInt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int SumNatural(int m, int n)
{
    int sum = m;
    if (m == n)
        return 0;
    else
    {
        m++;
        sum = m + SumNatural(m, n);
        return sum;
    }
}

int number1 = ReadInt("Введите число M -> ");
int number2 = ReadInt("Введите число N -> ");
System.Console.WriteLine(SumNatural(number1 - 1, number2));