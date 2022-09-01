/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */

Console.Write("Введите количество строк m: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов n: ");
int columns = Convert.ToInt32(Console.ReadLine());

double[,] array = new double[rows, columns];

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        int randomization = new Random().Next(-11, 11);
        array[i, j] = Math.Round(new Random().NextDouble() * randomization, 1);
    }
}

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write(array[i,j] + "\t");
    }
    Console.WriteLine();
}
