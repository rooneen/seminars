// Напишите программу которая принимает на вход число и выдает количество цифр в числе

// Console.Write("Введите число: ");
// string number = Console.ReadLine()!;
// Console.WriteLine($"В числе {number} - {SumNumb(array)} символов");

// int SumNumb(int [] array)
// {
//     int count = number.Length;

//     for (int i = 0; i < count; i++)
//     {
//         Console.Write($"{count} ");
//     }
//     return count;
// }    

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
Console.WriteLine($"В числе {number} - {SumNumb(number)} символов");

int SumNumb(int A){

    int count = 0;
    while(A > 0){
        count ++;
        A /= 10; // A = A / 10
    }
    return count;
}