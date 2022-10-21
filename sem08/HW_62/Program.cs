/*по желанию
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив: 
 1  2  3  4
12 13 14  5
11 16 15  6
10  9  8  7 */
const int cellWidth = 2;
void DrawLineTop(int len) //допилить чтобы выводил и нижнюю 
{
    int i = 1;
    string str = "┌­­"; //┌─┐ ┌─┐│└┘ ┌─┐│└┘┬┴ ┌─┐│└┘┬┴─
    str = "┌";
    while (i < len-1)
    {
        str += "──┬";
        i++;
    }
    str += "──┐";
    Console.Write($"{str}\n");
}
void View(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            Console.Write($"│{arr[i, j],cellWidth}");
        }
        Console.Write("│\n");
    }
}

int size = 7;// доделать ввод с клавы
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
DrawLineTop(size+1);
View(arrSpiral);
Console.WriteLine($"\nнаибольшее значение ячейки = {k = arrSpiral.Length},\nразмер массива {size} X {size}");
Console.Write("Для завершения нажать любую клавишу\n");
Console.ReadKey();