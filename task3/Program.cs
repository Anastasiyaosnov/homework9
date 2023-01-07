// Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Promt(string massage)
{
    Console.WriteLine($"{massage}");
    return Convert.ToInt32(Console.ReadLine());
}

int m = Promt("Введите значение m для вычисления функции Аккермана -> A(m,n)");
int n = Promt("Введите значение n для вычисления функции Аккермана -> A(m,n)");;

int A(int n, int m)
{
    if (n == 0)
    {
        return m + 1;
    }
    else
    {
        if ((n != 0) && (m == 0))
        {
            return A(n - 1, 1);
        }
        else
        {
            return A(n - 1, A(n, m - 1));
        }
    }
}


Console.Write($"A(m,n) = {A(m, n)}");