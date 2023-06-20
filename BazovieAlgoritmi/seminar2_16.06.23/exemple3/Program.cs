// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
// Если второе число не кратно первому, то программа выводить остаток от деления.


Console.WriteLine("Введите первое число");
int nomber1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int nomber2 = Convert.ToInt32(Console.ReadLine());

 int def = nomber1 % nomber2;

if (def == 0){
    Console.WriteLine($"число {nomber1} кратно числу {nomber2}");
    
} else
Console.WriteLine($"число {nomber1} не кратно числу {nomber2}, остаток {def}");
