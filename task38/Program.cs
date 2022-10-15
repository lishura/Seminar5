/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76*/

double [] CreateRandomArray(int N)
{
    double[] array = new double [N];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().NextDouble();
    }
    return array;
}

Console.WriteLine("Введите длину массива");
int N = int.Parse(Console.ReadLine());

double [] array = CreateRandomArray(N);
double max = array[0];
double min = array[0];
for (int i = 1; i < array.Length; i++)
{
   if (array[i]>max)
   {
        max = array[i];
   }
   if (array[i]<min)
   {
        min = array[i];
   }
}

double dif = max-min;

string arrayString = string.Join(", ", array);
Console.WriteLine("Массив " + arrayString);
Console.WriteLine("Разница между максимальным и минимальным элементом массива равна " + dif);

