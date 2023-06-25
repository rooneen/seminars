// Задайте массивю Напишите программу, которая определяет присутствует ли заданное число в массиве


Console.WriteLine("Введите размер массива: ");
int size = int.Parse(Console.ReadLine()!);

int[] array = GetArray(size);
Console.WriteLine($"[{String.Join(", ", array)}]");

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

if(Answer(array, number) == true) Console.WriteLine("Да");
else Console.WriteLine("Нет");

bool Answer(int[] array, int number)            //Метод поиска элемента
{
    foreach(int el in array)
    {
        if(el == number) return true;
    }
    return false;
}

int[] GetArray(int size){         //Функия заполнения массива (стандарт)!!!!
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(0, 11);
    }
    return result;
}