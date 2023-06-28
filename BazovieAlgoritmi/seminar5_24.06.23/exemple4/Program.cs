// задайте одномерный массив из 123 случайных чисел 
// Найдите количество элементов массива значения которых лежат в отрезке [10, 99]

Console.WriteLine("Введите размер массива: ");
int size = int.Parse(Console.ReadLine()!);

int[] array = GetArray(size, 1, 999);
Console.WriteLine($"[{String.Join(", ", array)}]");
int count = 0;

foreach (int el in array)
{
    count += el <=99 && el >= 10 ? 1 : 0;
}
Console.WriteLine($"количество элементов массива от 10 до 99 = {count}");

int[] GetArray(int size, int minValue, int maxValue){         
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}