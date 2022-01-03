﻿/* Написать программу, которая из имеющегося массива целых чисел формирует массив из четных чисел.
   Первоначальный массив можно ввести с клавиатуры, либо сгенерировать случайным образом.
   При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.*/

void PrintArray(int[] array)
{
    int count = array.Length;
    int IndArray = 0;
    while (IndArray < count)
    {
        Console.Write(array[IndArray]+"  ");
        IndArray++;
    }
}

Random Rnd = new Random();
int Ind = Rnd.Next(10, 20);
int[] ArrayNumbers = new int[Ind];

for (int i = 0; i < Ind; i++)
{
    ArrayNumbers[i] = Rnd.Next(-10, 10);
}

PrintArray(ArrayNumbers);

int index = 1;

for (int i = 0; i < Ind; i++)
{
    if (ArrayNumbers[i]%2 == 0)
    {
        index++;
    }
    i++;   
}

int[] ArrayEven = new int[index];
int i = 0;

for (int j = 0; j < index; j++)
{    
    if (ArrayNumbers[i]%2 == 0)
    {
        ArrayEven[j] = ArrayNumbers[i];
        j++;
    }
    i++;
}

PrintArray(ArrayEven);