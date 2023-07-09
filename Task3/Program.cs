//Задача: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int ReadInt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int funcAkkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return funcAkkerman(m - 1, 1);
    }
    else
    {
        return (funcAkkerman(m - 1, funcAkkerman(m, n - 1)));
    }
}

int number1 = ReadInt("Введите первое неотрицательное число -> ");
int number2 = ReadInt("Введите второе неотрицательно число -> ");
System.Console.WriteLine(funcAkkerman(number1, number2));