// Напишите программу, которая выводит случайное 3х значное число и удалите вторую цифру числа.


int number = new Random().Next(100, 1000);
int num1 = number / 100;
int num2 = number % 10;
int num = num1 * 10 + num2;

Console.WriteLine($"Рандомное число {number}");
Console.WriteLine($"Новое число {num}");