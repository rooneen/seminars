// перевести в двоичную систему счисления


// код группы
/*Console.Write("Введиде десятичное число: ");
int dec = int.Parse(Console.ReadLine()!);
Console.WriteLine($"{dec} в двоичной системе {String.Join(", ", GetDec(dec))}");

// метод перевода в двоичную сс
int[] GetDec(int dec)
{
    int[] Array = new int[16];
    for (int i = 0; i < Array.Length; i++)
    {
        Array[i] = dec % 2;
        dec /= 2;
    }
    
    Console.WriteLine($"[{String.Join(", ", Array)}]");
    ReverseArray1(Array);
    Console.WriteLine($"[{String.Join(", ", Array)}]");
    return Array;
}

//первый вариант разворота массива
void ReverseArray1(int[] inArray)
{
    for(int i = 0; i < inArray.Length / 2; i++)
    {
        int temp = inArray[i]; // временная переменная для первого элемента массива
        inArray[i] = inArray[inArray.Length - 1 - i]; // переносим в первый элемент - последний элемент
        inArray[inArray.Length - 1 - i] = temp; // переносим в последний элемент значение первого элемента и временной переменной
    }
}*/

// код преподавателя

Console.Write("Введиде десятичное число: ");
int dec = int.Parse(Console.ReadLine()!);

string res1 = Convert.ToString(dec, 2);

Console.WriteLine($"{dec} -> {res1}");