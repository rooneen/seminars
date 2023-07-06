// Задайте двумерный массив, Найдите элементы у которых оба индекса четные и замените эти элементы на их квадраты



Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов: ");
int colums = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, colums, 0, 10);
PrintArray(array);

Console.WriteLine();
PrintArray(GetPow(array));

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

int[,] GetPow(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                Array[i, j] = Convert.ToInt32(Math.Pow(Array[i, j], 2));
            }
        }
    }
    return Array;
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
