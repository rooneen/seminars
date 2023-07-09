// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.



Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов: ");
int colums = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, colums, 0, 10);
PrintArray(array);

Console.WriteLine();
ChangeRow(array);


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

void ChangeRow(int[,] inArray)
{
    for (int j = 0; j < inArray.GetLength(0); j++)
    {
        int temp = inArray[0, j];
        inArray[0, j] = inArray[inArray.GetLength(0) - 1, j];
        inArray[inArray.GetLength(0) - 1, j] = temp;
    }
    PrintArray(inArray);
}