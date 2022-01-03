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
    ArrayNumbers[i] = Rnd.Next(0, 20);
}

PrintArray(ArrayNumbers);

int index = 0;

for (int i = 0; i < Ind; i++)
{
    if (ArrayNumbers[i] > 8)
    {
        index++;
    }
}

int[] ArrayMoreThanEight = new int[index];
index = 0;

for (int i = 0; i < Ind; i++)
{    
    if (ArrayNumbers[i] > 8)
    {
        ArrayMoreThanEight[index] = ArrayNumbers[i];
        index++;
    }
}

Console.WriteLine();
if (index == 0)
{
    Console.Write("No numbers greater than 8");
}
PrintArray(ArrayMoreThanEight);