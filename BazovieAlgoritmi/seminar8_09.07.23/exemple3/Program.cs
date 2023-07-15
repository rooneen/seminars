// из двуерного массива целых чисел удалить строку и столбец, на пересечнии которых расположен наименьший элемент 

 Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов: ");
int colums = int.Parse(Console.ReadLine()!);


int[,] array = GetArray(rows, colums, 0, 10);
PrintArray(array);
delCilRow(array, searchMin(array));


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

int[] searchMin(int[,] arr)
{
    int[] temp = new int[]{0, 0};
    int min = arr[0, 0];

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if(arr[i, j] < min)
            {
                temp = arr[i, j];
                temp[0] = i;
                temp[1] = j;
            }
                
        }
    }

    return temp;
}

void delCilRow(int[,] arr, int[] temp)
{
    int[,] tempArr = new int[arr.GetLength(0) - 1, arr.GetLength(1) - 1];
    int row = 0;
    int col = 0;

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if(i == temp[0])
            {
                 tempArr[row, col] = arr[i, j];   
            }
        }
        
        ++row;
        col = 0;
    }
    PrintArray(tempArr);
}