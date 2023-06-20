// Напишите  программу, 
// которая по заданному номеру четверти показывает диапазон возможных координат точек в этой четверти (x и y)

Console.Write("Введите номер четверти: ");
// int number = int.Parse(Console.ReadLine()!);
int number = new Random().Next(1, 10);
Console.WriteLine(number);

switch (number)
{
    case (1):
    {
        Console.WriteLine("X > 0, Y > 0");
        break;
    }
    case (2):
    {
        Console.WriteLine("X < 0, Y > 0");
        break;
    }
    case (3):
    {
        Console.WriteLine("X < 0, Y < 0");
        break;
    }
    case (4):
    {
        Console.WriteLine("X > 0, Y < 0");
        break;
    }
    default:
        Console.WriteLine("Четверти с таким номером не существует");
        break;
}
