/*Задача 58: Задайте две матрицы. Напишите программу, которая 
будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/

int[,] matrixA = new int[2, 2];

int[,] matrixB = new int[2, 2];

int[,] resultArr = new int[matrixA.GetLength(0), matrixB.GetLength(1)];

void fillArray(int[,] arr)//заполнение массива случ. числами
{
    int row = arr.GetLength(0);
    int col = arr.GetLength(1);
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            arr[i, j] = new Random().Next(0, 10);
        }
    }
}

void printArray(int[,] arr)// вывод массива
{
    int row = arr.GetLength(0);
    int col = arr.GetLength(1);
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            Console.Write($"|{arr[i, j]}");
        }
        Console.Write("|\n");
    }
    Console.WriteLine();
}

void matrixMultiplication()//Умножение матриц
{
    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
            for (int k = 0; k < matrixB.GetLength(0); k++)
            {
                resultArr[i, j] += matrixA[i, k] * matrixB[k, j];
            }
        }
    }
}

Console.Clear();
//Заполняем массивы
fillArray(matrixA);
fillArray(matrixB);
//Вывод для контроля
Console.WriteLine("Матрица A");
printArray(matrixA);
Console.WriteLine("Матрица B");
printArray(matrixB);
//Умножение матриц
if (matrixA.GetLength(0) == matrixB.GetLength(1))
{
    matrixMultiplication();
    //Вывод результата
    Console.WriteLine("Результат A x B");
    printArray(resultArr);
}
else
{
    Console.WriteLine("Умножение матриц А и В невозможно!");
}
