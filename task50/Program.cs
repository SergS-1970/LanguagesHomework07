/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1,7 -> такого числа в массиве нет (1 строчка, 7 столбец) */

Console.Write("Введите количество строк m: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов n: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[rows, columns];

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        array[i, j] = new Random().Next(-100, 100);
    }
}

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine();
}

Console.WriteLine("Введите позицию искомого элемента в массиве: ");
Console.Write("Индекс строки: ");
int stringWithElement = Convert.ToInt32(Console.ReadLine());
Console.Write("Индекс столбца: ");
int columnsWithElement = Convert.ToInt32(Console.ReadLine());

if (stringWithElement >= 0 && stringWithElement < rows && 
columnsWithElement >=0 && columnsWithElement < columns)
{
    Console.WriteLine($"Элемент массива array[{stringWithElement},{columnsWithElement}] равен {array[stringWithElement, columnsWithElement]}");
}
else
Console.WriteLine($"Элемента array[{stringWithElement},{columnsWithElement}] не существует");
