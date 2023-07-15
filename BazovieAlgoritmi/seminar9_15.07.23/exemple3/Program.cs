// Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Выполнить с помощью рекурсии.


Console.Write("Введите значение M: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение N: ");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(PrintNumbers(M, N));

string PrintNumbers(int start, int end)
{
    if(start == end) return start.ToString();
    return (start + " " + PrintNumbers(start + 1, end));
}

