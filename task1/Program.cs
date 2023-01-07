// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.

// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"


int Promt(string massage)
{
    Console.WriteLine($"{massage}");
    return Convert.ToInt32(Console.ReadLine());
}

bool Parity(int number)
{
    if (number % 2 != 0)
    {
        return true;
    }
    return false;
}

string Print(int M, int N)
{
    if (M<=N)
    {
        return $"{M} " + Print(M+2,N);
    }
    else return String.Empty;
}


int M = Promt("Введите значение M (в промежутке от M до N)");
int N = Promt("Введите значение N (в промежутке от M до N)");;

if (Parity(N))
{
    N -= 1;
}
if (Parity(M))
{
    M += 1;
}
Console.Write("Все чётные натуральные числа в промежутке от M до N: ");
Console.Write(Print(M,N));

