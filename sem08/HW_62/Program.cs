/*по желанию
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив: 
 1  2  3  4
12 13 14  5
11 16 15  6
10  9  8  7 */
const int cellWidth = 3;

void DrawLineTab(int sizeData, int sizeCell, int pozType)
// sizeData - число данных, sizeCell - размер ячейки
// pozType - варианты 0 - верх, 1 - низ, 2- середина
{
    string result = "";
    string sDiv = "┌┬┐";
    if (pozType == 1) sDiv = "└┴┘";
    if (pozType == 2) sDiv = "├┼┤";
    string cellSynb = new string('─', sizeCell);
    for (int i = 0; i < sizeData; i++)
    {
        result += cellSynb;
        if (i != sizeData-1) result += sDiv.Substring(1, 1);
    }

    Console.WriteLine($"{sDiv.Substring(0, 1)}{result}{sDiv.Substring(2, 1)}");
}
void View(int[,] arr)
{
    int iMax=arr.GetLength(0);
    int jMax= arr.GetLength(1);
    for (int i = 0; i < iMax; i++)
    {
        for (int j = 0; j < jMax; j++)
        {
            Console.Write($"│{arr[i, j],cellWidth}");
        }
        Console.Write("│\n");
        if (i<iMax-1) DrawLineTab(iMax,cellWidth,2);
    }
}

Console.Clear();
Console.Write("Введите размер массива -> :");
int size = Convert.ToInt32(Console.ReadLine());
//добавить контроль ввода только целое число
int step = 1;
int[] indx = new int[] { 0, 0 };
int[,] arrSpiral = new int[size, size];
int k = 1;
int strt = 0;
void WayForward(int ind)
{
    arrSpiral[indx[0], indx[1]] = k;
    indx[ind] += step;
    k++;
}

void WayBack(int ind)
{
    arrSpiral[indx[0], indx[1]] = k;
    indx[ind] -= step;
    k++;

}

while (k < arrSpiral.Length)
{
    while (indx[1] < size - 1)
    {
        WayForward(1);
    }
    while (indx[0] < size - 1)
    {
        WayForward(0);
    }
    while (indx[1] > strt)
    {
        WayBack(1);
    }
    while (indx[0] > strt)
    {
        WayBack(0);
    }
    strt += 1;
    indx[0] += 1;
    indx[1] += 1;
    size -= 1;
}


size = arrSpiral.GetLength(0);
if (size % 2 != 0)
{
    arrSpiral[size / 2, size / 2] = arrSpiral.Length;
}
Console.Clear();
Console.WriteLine("Заполнение массива по спирали");
DrawLineTab(size,cellWidth,0);
View(arrSpiral);
DrawLineTab(size,cellWidth,1);
Console.WriteLine($"\nнаибольшее значение ячейки = {k = arrSpiral.Length},\nразмер массива {size} X {size}");
Console.Write("\nДля завершения нажать любую клавишу\n");
Console.ReadKey();