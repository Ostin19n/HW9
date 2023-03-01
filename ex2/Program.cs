// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int numberM = GetNum("Введите число M");
int numberN = GetNum("Введите число N");

void SumElements(int m, int n, int sum)
{
    if (m > n)
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}");
        return;
    }
    sum = sum + (m++);
    SumElements(m, n, sum);
}
SumElements(numberM, numberN, 0);


int GetNum(string text)
{
    Console.WriteLine(text);
    return int.Parse(Console.ReadLine());
}
