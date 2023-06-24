// Напишите программу которая принимает на вход число и выдает количество цифр в числе

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
string numberString = Convert.ToString(number);
Console.WriteLine($"В числе {number} - {SumNumb(number)} символов");

int SumNumb(int array)
{
    int count = numberString.Length;

    for (int i = 0; i < array; i++)
    {
        count += i;
    }
    return count;
}    

// Console.Write("Введите число: ");
// int number = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"В числе {number} - {SumNumb(number)} символов");

// int SumNumb(int A){

//     int count = 0;
//     while(A > 0){
//         count ++;
//         A /= 10; // A = A / 10
//     }
//     return count;
// }