// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с 
// помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
Console.WriteLine();
Console.WriteLine("T A S K   #    1");
Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Числа в промежутке от {n} до 1: ");
PrintDiap(n);

void PrintDiap(int n)
{
    if (n > 1)
    {
        Console.Write($"{n}, ");
        PrintDiap(n - 1);
    }
    else Console.WriteLine($"{n}. ");
}

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.WriteLine();
Console.WriteLine("T A S K   #    2");
Console.WriteLine("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Числа в промежутке между ними (включительно): ");
PrintDiapasone(a, b);
int sum = 0;
int summary = SumDiapasone(a, b, sum);
Console.WriteLine($"Их сумма: {summary}");

void PrintDiapasone(int n, int m)
{
    if (n < m)
    {
        Console.Write($"{n}, ");
        PrintDiapasone(n + 1, m);
    }
    else if (n > m)
    {
        Console.Write($"{m}, ");
        PrintDiapasone(n, m + 1);
    }
    else Console.WriteLine($"{n}. ");
}

int SumDiapasone(int n, int m, int sum)
{
    if (n < m) return sum = n + SumDiapasone(n + 1, m, sum);
    else if (n > m) return sum = m + SumDiapasone(n, m + 1, sum);
    else return sum += n;
}

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
Console.WriteLine();
Console.WriteLine("T A S K   #    3");
Console.WriteLine("Введите число M: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int y = Convert.ToInt32(Console.ReadLine());
int result = 0;
result = AccermanFunction(x, y, result);
Console.WriteLine($"Результат равен: {result}");

int AccermanFunction(int m, int n, int result)
{
    if(m == 0) {return n + 1;}
    else if((m > 0) && (n == 0)) {return AccermanFunction(m - 1, 1, result);}
    else {return AccermanFunction(m - 1, AccermanFunction(m, n - 1, result), result);}
}