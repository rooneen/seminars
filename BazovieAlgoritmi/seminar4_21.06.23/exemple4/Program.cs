// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

int[] GetArray(int size)
{
    int[] result = new int[size]; // создает целочисленный массив с размером size
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(0, 2);        
    }
    return result;
}

int[] array = GetArray(8);
Console.WriteLine($"[{String.Join(",", array)}]"); //String.Join вывод строки через разделитель (работает только с строками и одномерными массивами)