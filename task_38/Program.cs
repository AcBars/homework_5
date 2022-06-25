/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и
минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

using static System.Console;
Clear();
WriteLine("Введите длину массива.");
int size=int.Parse(ReadLine());
double [] array=FloatGetRandomArray(size);
WriteLine($"[{String.Join(". ", (array))}]");
WriteLine($"Разница между максимальным и минимальным элементом представленного массива равна {MaxEltmetArray(array)-MinEltmetArray(array)}");




double [] FloatGetRandomArray(int size)
{
    double [] arr=new double [size];
    for (int i=0; i<size; i++)
    {
        arr[i]=(new Random().Next(-100,101))/10.0;
    }
    return arr;
}

double MaxEltmetArray(double [] array)
{
    double max=array[0];
    for(int i=1; i<array.Length; i++)
    {
        if (max<array[i]) max=array[i];
    }
    return max;
}

double MinEltmetArray(double [] array)
{
    double min=array[0];
    for(int i=1; i<array.Length; i++)
    {
        if (min>array[i]) min=array[i];
    }
    return min;
}