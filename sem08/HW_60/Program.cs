/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/

Console.Clear();
int[] arrayDonor = new int[100];
int rowSize = 2;
int colSize = 2;
int levSize = 2;
if (rowSize >= 0 && colSize >= 0 && levSize >= 0)
{
int[,,] resultArr = new int[rowSize, colSize, levSize];
for (int i = 10; i < 100; i++) arrayDonor[i] = i; // массив всех двузначных целых
    Console.WriteLine($"Массив размером {rowSize} x {colSize} x {levSize}\n");
    for (int k = 0; k < levSize; k++)
    {
        for (int i = 0; i < rowSize; i++)
        {
            for (int j = 0; j < colSize; j++)
            {
                while (resultArr[i, j, k] == 0)
                {
                    int indx = new Random().Next(0, 100);
                    if (arrayDonor[indx] != -1)
                    {
                        resultArr[i, j, k] = arrayDonor[indx];
                        arrayDonor[indx] = -1;
                    }
                }
                Console.Write($" | {resultArr[i, j, k]}({i},{j},{k})");
            }
            Console.Write(" |\n");
        }
    }
}
else Console.WriteLine("Отрицательные индексы массива недопустимы!");
Console.WriteLine();