// Напишите программу, которая принимает на вход число (N) и выдает таблицу квадратов чисел от 1 до n

Console.Write("Введите число: ");

int N = int.Parse(Console.ReadLine()!);

for (int i = 1; i <= N; i++)
{
    int sqr = Convert.ToInt32(Math.Pow(i, 2));
    Console.WriteLine(sqr);
}