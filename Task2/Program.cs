// Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"


string PrintNumber(int m, int n)
{
    if (n == m) return n.ToString();
    else
    {
        return PrintNumber(m, n - 1) + " " + n.ToString();
    }
}

Console.WriteLine(PrintNumber(4, 8));