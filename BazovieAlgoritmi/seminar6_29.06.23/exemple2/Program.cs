// Напишите программу, которая принимает на вход три числа и проверяет,
// может ли существовать треугольник с сторонами такой длинны
// теорема - каждая сторона треугольника меньше суммы двух других сторон

Console.Write("Введиде длинну стороны А: ");
int A = int.Parse(Console.ReadLine()!);

Console.Write("Введиде длинну стороны B: ");
int B = int.Parse(Console.ReadLine()!);

Console.Write("Введиде длинну стороны C: ");
int C = int.Parse(Console.ReadLine()!);

if(GatTriangle(A, B, C)) Console.WriteLine($"Треугольник со сторонами {A} {B} {C} существует");
else Console.Write($"Треугольник со сторонами {A} {B} {C} не существует");

bool GatTriangle(int A, int B, int C)
{
    if((A < B + C) && (B < A + C) && (C < A + B)) return true;
    else return false;
}
