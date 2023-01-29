/* 
Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементами массива.
[3 7 22 2 78] -> 76  
*/

int size = ReadInt("Введите размерность массива: ");
int min = ReadInt("Введите минимальное число массива: ");
int max = ReadInt("Введите максимальное число массива: ");
int [] number = new int[size];

FillArrayRandomNumber(number);
PrintArray(number);

int maxFillarray = number[0];
int minFillarray = number[0];

for (int i = 0; i < number.Length; i++)
{
    if (number[i] > maxFillarray)
    {
        maxFillarray = number[i];
    }
    if (number[i] < minFillarray)
    {
        minFillarray = number[i];
    }
}
Console.WriteLine($"Разница между максимальным и минимальным числом = {maxFillarray - minFillarray}");


void FillArrayRandomNumber(int [] array) 
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
}

void PrintArray(int[] array) 
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}