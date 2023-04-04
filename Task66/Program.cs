// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int f(int m, int n)
{
    if (m == n)
        return m;
    return f(m, n - 1) + n;
}

Console.Clear();
Console.Write("Введите начальное число: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите конечное число: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма чисел в промежутке от {m} до {n}: {f(m, n)}");