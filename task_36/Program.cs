/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
*/

using static System.Console;
Clear();
WriteLine("Введите длину массива.");
int size=int.Parse(ReadLine());







int [] GetRandomArray(int size)
{
    int [] arr=new int [size];
    for (int i=0; i<size; i++)
    {
        arr[i]=new Random().Next(0,100);
    }
    return arr;
}