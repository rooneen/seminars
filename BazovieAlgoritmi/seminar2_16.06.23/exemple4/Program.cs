//Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23


Console.WriteLine("Введите число");
int nomber = Convert.ToInt32(Console.ReadLine());

// int dev1 = nomber % 7;
// int dev2 = nomber % 23;

if (nomber % 7 == 0  && nomber % 23 == 0){
    Console.WriteLine($"Число {nomber} кратно 7 и 23");

} else
Console.WriteLine($"Число {nomber} не кратно 7 и 23");
