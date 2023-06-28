// напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные и наоборот


Console.WriteLine("Введите размер массива: ");
int size = int.Parse(Console.ReadLine()!);


int[] array = GetArray(size, -999, 999);
Console.WriteLine($"[{String.Join(", ", array)}]");

for(int i = 0; i < size; i++)
{
    array[i] *= -1;
}
Console.WriteLine($"[{String.Join(", ", array)}]");

int[] GetArray(int size, int minValue, int maxValue)
{         
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}