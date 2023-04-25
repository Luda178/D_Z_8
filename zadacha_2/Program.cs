
using System;
using static System.Console;

Clear();

Write("Введите количество строк массива: ");
int m = Convert.ToInt32(ReadLine());
Write("Введите количество столбцов массива: ");
int n = Convert.ToInt32(ReadLine());
int[,] RandomArray = new int[m,n];

void mas(int m, int n)
{
    Random rand = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            RandomArray[i,j] = rand.Next(1,9);
        }
    }
}

void printm(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write($"{array[i,j]} ");
        }
        WriteLine();
    }
}

mas(m,n);
WriteLine("\nИсходный массив: ");
printm(RandomArray);

int SumLine(int[,] array, int i)
{
    int sum = array[i,0];
    for (int j = 1; j < array.GetLength(1); j++)
{
sum += array[i,j];
}
    return sum;
}

int minSum = 1;
int sum = SumLine(RandomArray, 0);
for (int i = 1; i < RandomArray.GetLength(0); i++)
{
    if (sum > SumLine(RandomArray, i))
    {
    sum = SumLine(RandomArray, i);
    minSum = i+1;
    }
}
WriteLine($"\nСтрока c наименьшей суммой элементов: {minSum}");
