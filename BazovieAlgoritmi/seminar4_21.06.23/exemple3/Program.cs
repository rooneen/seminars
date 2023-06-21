// Напишите программу, которая принимает на вход число N и выдает произведение от 1 до N.

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Произведение чисел {number} = {GetMuliply(number)}");

int GetMuliply(int limit){

    int result = 1;

    for (int i = 2; i <= limit; i++)
    {
        result *= i;
    }
    return result;
}