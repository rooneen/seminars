// Напишите программу, которая будет принимать на вход два числа и проверяет, является ли одно число квадратом другого.

Console.WriteLine("Введите первое число");
int nomber1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int nomber2 = Convert.ToInt32(Console.ReadLine());

int mult1 = nomber1 * nomber1;
int mult2 = nomber2 * nomber2;

if (mult1 == nomber2 || mult2 == nomber1){
    Console.WriteLine("Является");
} else Console.WriteLine("Не является");