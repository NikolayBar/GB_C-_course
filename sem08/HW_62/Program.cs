/*по желанию
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив: 
 1  2  3  4
12 13 14  5
11 16 15  6
10  9  8  7 */
const int cellWidth = 2;
void View(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            Console.Write($"|{arr[i, j],cellWidth}");
        }
        Console.Write("|\n");
    }
}

int size = 4;
int step = 1;
int[] indx = new int[] { 0, 0 };
int[,] arrSpiral = new int[size, size];
int k = 1;
int strt = 0;

 while (k < arrSpiral.Length)
{
    while (indx[1] < size - 1)
    {
        arrSpiral[indx[0], indx[1]] = k;
        indx[1] += step;
        k++;
    }
    while (indx[0] < size - 1)
    {
        arrSpiral[indx[0], indx[1]] = k;
        indx[0] += step;
        k++;
    }

    while (indx[1] > strt)
    {
        arrSpiral[indx[0], indx[1]] = k;
        indx[1] -= step;
        k++;
    }

    while (indx[0] > strt)
    {
        arrSpiral[indx[0], indx[1]] = k;
        indx[0] -= step;
        k++;
    }
    strt += 1;
    indx[0] += 1;
    indx[1] += 1;
    size -=1;
}

Console.Clear();
View(arrSpiral);
Console.WriteLine($"крайнее значение k={k}");
