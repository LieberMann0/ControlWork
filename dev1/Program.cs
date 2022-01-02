/* Написать программу, которая из имеющегося массива целых чисел формирует массив из четных чисел.
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
int[] ArrayEven = {0};

for (int i = 0; i < Ind; i++)
{
    ArrayNumbers[i] = Rnd.Next(-10, 10);
}

PrintArray(ArrayNumbers);
Console.WriteLine();

