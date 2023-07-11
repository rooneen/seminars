// Задайте прямоугольный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Программа считает сумму элементов в каждой строке и выдает номер строки с наименьшей суммой элементов.

Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов: ");
int colums = int.Parse(Console.ReadLine()!);

while (rows == colums || rows == 0 || colums == 0)
{
    Console.WriteLine("Введите НЕ! одинаковые значения");
    Console.Write("Введите количество строк: ");
    rows = int.Parse(Console.ReadLine()!);

    Console.Write("Введите количество столбцов: ");
    colums = int.Parse(Console.ReadLine()!);
}

int[,] array = GetArray(rows, colums, 0, 10);
PrintArray(array);

Console.WriteLine($"Номер строки с минимально суммой -> {ArrayMin(array)}");


//Метод заполнения двумерного массива

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue - 1);
        }
    }
    return result;
}


//Метод вывода двумерного массива

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }

}

int ArrayMin(int[,] inArray)
{
    int minSum = 0;
    int sum = 0;
    int minRow = 0;

    for (int j = 0; j < inArray.GetLength(1); j++)
    {
        minSum += inArray[0, j];
    }

    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            sum = inArray[i, j];
        }

        if (sum < minSum)
        {
            minSum = sum;
            minRow = i;
        }
    }
    return minRow + 1;
}
