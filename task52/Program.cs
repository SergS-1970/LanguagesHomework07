/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

Console.Write("Введите количество строк m: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов n: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[rows, columns];

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        array[i, j] = new Random().Next(11);
    }
}

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write(array[i, j] + " \t");
    }
    Console.WriteLine();
}

double[] averageForColumn = new double[columns];

for (int j = 0; j < columns; j++)
{

    for (int i = 0; i < rows; i++)
    {
        averageForColumn[j] += array[i, j];
    }
    averageForColumn[j] = Math.Round(averageForColumn[j] / rows, 2);
}

Console.WriteLine("Средние значения по столбцам: ");
Console.WriteLine($"[{String.Join("\t", averageForColumn)}]");