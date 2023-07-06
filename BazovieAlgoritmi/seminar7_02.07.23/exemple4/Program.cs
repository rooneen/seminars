// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали

int[,] get2dArray(int rows, int columns, int min, int max)
{
      int [,] array = new int[rows,columns];
      for (int i = 0; i < rows; i++)
      {
            for (int j = 0; j < columns; j++)
            {
                  array[i,j] = new Random().Next(min,max);
            }
      }
      return array;
}

void print2dArray(int[,] array)
{
      for (int i = 0; i < array.GetLength(0); i++)
      {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                  Console.Write($"{array[i,j]} ");
            }

            Console.WriteLine();
      }
}

void getSum(int[,] array)
{     
      int rows = array.GetLength(0);
      int columns = array.GetLength(1);

      int number = 0;
      if (rows > columns) {number = columns;}
      else {number = rows;}

      int[] numbers = new int[number];
      int sum = 0;
      for (int i = 0; i < rows; i++)
      {
            for (int j = 0; j < columns; j++)
            {
                  if (i==j)
                  {
                        numbers[i] = array[i,j];
                        sum += array[i,j];
                  }
            }
      }

      Console.WriteLine($"{String.Join(", ",numbers)} --> {sum}");
}


Console.WriteLine("Введите кол-во строк в массиве: ");
int rows = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите кол-во колонок в массиве: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = get2dArray(rows,columns,0,10);
print2dArray(array);
getSum(array);