//Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.

int ReadInt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void OutputEven(int m, int n)
{
    if (m % 2 == 0)
    {
        m += 1;
    }
    if (m > n)
    {
        return;
    }
    System.Console.WriteLine(m + 1);
    OutputEven(m + 2, n);
}

int number1 = ReadInt("Введите число M -> ");
int number2 = ReadInt("Введите число N -> ");
OutputEven(number1, number2 - 1);