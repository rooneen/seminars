// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9,9]
// Найдите сумму отрицательных и положительных элементов массива

int[] array = GetArray(12, -9, 9);
Console.WriteLine($"[{String.Join(", ", array)}]");

int pozitiveSum = 0;
int negativeSum = 0;

foreach (int el in array){          //Тернальный оператор foreach (проходит по массиву и сохраняет в переменную el. ? если условие true то выполняется первое условие : если false то второе условие; )
    pozitiveSum += el > 0 ? el : 0;
    negativeSum += el < 0 ? el : 0;
}

// if(el > 0){                                  //решение без тернального оператора 
//     pozitiveSum = pozitiveSum + el;
// }
// else{
//     negativeSum = negativeSum + el;
// }

Console.WriteLine($"Pozitive sum = {pozitiveSum}, Negative sum = {negativeSum}");

int[] GetArray(int size, int minValue, int maxValue){         //Функия заполнения массива (стандарт)!!!!
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}