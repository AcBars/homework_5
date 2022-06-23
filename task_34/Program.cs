/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/

using static System.Console;
Clear();
WriteLine("Введите желаемую длину массива");
int a = Convert.ToInt32(ReadLine());
int [] array=RandomArray(a);

WriteLine($"В массиве [{String.Join(", ", array)}] {EvenCount(array)} чётных чисел");


int [] RandomArray(int size)
{
    int [] arr = new int [size];
    for(int i=0; i<size; i++)
    {
        arr [i]=new Random().Next(100,1000);
    }
    return arr;
}



int EvenCount(int [] array)
{
    int count=0;
    for(int i=0; i<array.Length; i++)
    {
       count= array[i]%2==0 ? count=count+1 : count=count+0;
    }
    return count;
}