// найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент,
// второй и предпоследний и тд

Console.WriteLine("Введите размер массива: ");
int size = int.Parse(Console.ReadLine()!);

int[] numbers = new int[size];
numbers = GetArray(numbers, 1, 10);



int[] GetArray(int size, int minValue, int maxValue){         
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}