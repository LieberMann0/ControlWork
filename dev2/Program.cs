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

Random Rnd = new Random();
int Ind = Rnd.Next(10, 20);
int[] ArrayNumbers = new int[Ind];

for (int i = 0; i < Ind; i++)
{
    ArrayNumbers[i] = Rnd.Next(-10, 10);
}

PrintArray(ArrayNumbers);

