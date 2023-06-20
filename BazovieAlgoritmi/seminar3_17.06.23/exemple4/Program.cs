// проверка равенства первого и третьего числа

Console.Write("Введите трехзначное число: ");
string number = Console.ReadLine()!;

if(number.Length == 3){
    if(number[0] == number[2]){
        Console.WriteLine("Числа равны");
    }
    else{
        Console.WriteLine("Числа не равны");
    }
}
else{
    Console.WriteLine("Введено не 3х значное число");
}