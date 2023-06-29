// Напишите программу, котрая перевернет одномерный массив (последний элемент будет на первом месте, а первый на последнем и т.д.)

Console.WriteLine("Введите размер массива: ");
int size = int.Parse(Console.ReadLine()!);

int[] array = GetArray(size, 10, 99);
Console.WriteLine($"[{String.Join(", ", array)}]");

ReverseArray1(array);
Console.WriteLine($"[{String.Join(", ", array)}]");

//первый вариант разворота массива
void ReverseArray1(int[] inArray)
{
    for(int i = 0; i < inArray.Length / 2; i++)
    {
        int temp = inArray[i]; // временная переменная для первого элемента массива
        inArray[i] = inArray[inArray.Length - 1 - i]; // переносим в первый элемент - последний элемент
        inArray[inArray.Length - 1 - i] = temp; // переносим в последний элемент значение первого элемента и временной переменной
    }
}

int[] GetArray(int size, int minValue, int maxValue){         
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}
