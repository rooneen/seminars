// Напишите программу которая принимает на вход число А и выдает сумму чисел от 1 до А

Console.Write("Введите число: ");
int limit = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма чисел от 1 до {limit} = {GetSum(limit)}");

//функция подсчета суммы от 1 до А
int GetSum(int A)
{
    int sum = 0;
    for (int i = 1; i <= A; i++)    
    {
     sum += i; //sum = sum + i;    
    }
    return sum;
}