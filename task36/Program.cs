//+Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19

//[-4, -6, 89, 6] -> 0

int[] CreateRandomArray(int N, int min, int max)
{
    int[] array = new int [N];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
    }
    return array;
}

int PrintAndGetValue(string message)
{
    Console.WriteLine(message);
    int value = int.Parse(Console.ReadLine());
    return value;
}

int N = PrintAndGetValue("Введите длину массива ");
int min = PrintAndGetValue("Введите минимальное значение элементов массива ");
int max = PrintAndGetValue("Введите максимальное значение элементов массива ");

int [] array = CreateRandomArray(N, min, max);

int sum = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i]%2 !=0)
    {
        sum += array [i];
    }
}
string arrayString = string.Join(",", array);
Console.WriteLine("Массив " + arrayString);
Console.WriteLine("Сумма нечетных элементов массива равна" + sum);