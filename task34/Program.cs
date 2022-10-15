/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных
 чисел в массиве.

[345, 897, 568, 234] -> 2*/

int[] CreateRandomArray(int N, int min, int max)
{
    int [] array = new int [N];
    for (int i = 0; i < array.Length; i++)
    {
        array [i] = new Random().Next(min,max);
    }
    return array;
}

Console.WriteLine("Введите длину массива");
int N = int.Parse(Console.ReadLine());
int min = 100;
int max = 1000;

int[] input = CreateRandomArray(N, min, max);

int count = 0;
for (int i = 0; i < input.Length; i++)
{
    if (input[i]%2==0)
    {
        count+=1;
    }
}

string inputString = string.Join(", ", input);
Console.WriteLine("Массив " + inputString);
Console.WriteLine("Количество четных элементов в массиве " + count);