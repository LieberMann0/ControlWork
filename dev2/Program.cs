// Написать программу, которая из имеющегося массива целых чисел
// формирует массив из чисел, больших 8.

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

