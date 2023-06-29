// Напишите программу, котрая перевернет одномерный массив (последний элемент будет на первом месте, а первый на последнем и т.д.)

Console.WriteLine("Введите размер массива: ");
int size = int.Parse(Console.ReadLine()!);

int[] array = GetArray(size, 10, 99);
Console.WriteLine($"[{String.Join(", ", array)}]");

int[] rezultArray = ReverseArray2(array);
Console.WriteLine($"[{String.Join(", ", rezultArray)}]");

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

// второй вариант разворота массива
int[] ReverseArray2(int[] inArray)
{
    int[] rezult = new int[inArray.Length];
    for(int i = 0; i < inArray.Length; i++)
    {
        rezult[i] = inArray[inArray.Length - i - 1];
    }
    return rezult;
}

int[] GetArray(int size, int minValue, int maxValue){         
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}
