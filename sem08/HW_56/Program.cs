/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/
Console.Clear();
int rowSize = 4;
int colSize = 4;
int[] rowSumm = new int[rowSize];
int[,] checkingArray = new int[rowSize, colSize];

for (int i = 0; i < rowSize; i++)
{
    for (int j = 0; j < colSize; j++)
    {
        checkingArray[i, j] = new Random().Next(0, 10);
        rowSumm[i] = rowSumm[i] + checkingArray[i, j];
        Console.Write($"|{checkingArray[i, j]}");
    }
    Console.Write("|\n");
}
int minSum = rowSumm[0];
int minIndex = 0;
for (int i = 0; i < rowSize; i++)
{
    if (minSum > rowSumm[i])
    {
        minSum = rowSumm[i];
        minIndex = i;
    }
}

Console.WriteLine();
Console.WriteLine(String.Join("|", rowSumm));
Console.WriteLine($"Минимальная сумма элементов ({minSum}) в строке {minIndex}");
