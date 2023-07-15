// Напишите программу, которая на вход принимает два числа А и В и возводит число А в целую степень В с помощью рекурсии

Console.WriteLine("Введите число А: ");
int A = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите степень числа А: ");
int B = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Число {A} в степени {B} = {Pow(A, B)}");

int Pow(int number, int rank)
{
    if(rank == 0) return 1;
    if(rank == 1) return number;
    return(number * Pow(number, rank - 1));
}