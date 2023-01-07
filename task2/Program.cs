// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Promt(string massage)
{
    Console.WriteLine($"{massage}");
    return Convert.ToInt32(Console.ReadLine());
}

int sum(int m, int n)
{
    if (n<m)return 0;
    else return n + sum(m, n-1);
}


int a = Promt("Введите значение M (в промежутке от M до N)");
int b = Promt("Введите значение N (в промежутке от M до N)");;

Console.Write($"сумма натуральных элементов в промежутке от M до N -> {sum(a,b)}");