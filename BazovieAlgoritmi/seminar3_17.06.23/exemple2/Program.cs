// Напишите программу, которая принимает на вход координаты двух точек и нахолит расстояние между ними в 2D пространстве


Console.Write("Введите координату Х точки А: ");
int ax = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату У точки А: ");
int ay = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату Х точки В: ");
int bx = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату У точки В: ");
int by = int.Parse(Console.ReadLine()!);


double AB = Math.Sqrt(Math.Pow((bx - ax), 2) +Math.Pow((by-ay), 2)); //Math.Sqrt - вычесть корень, Math.Pow - возвести в степень (степень после запятой)

Console.WriteLine($"Расстояние между точками = {AB:f2}"); // :fn - округляет до "n" символов после запятой


