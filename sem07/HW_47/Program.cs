/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9
*/

bool СheckForNumbers(string testOnDigits)
{
    char firstSymb = Char.Parse(testOnDigits.Substring(0, 1));
    if (firstSymb == '-' | firstSymb == '+')
    {
        testOnDigits = testOnDigits.Remove(0, 1);
    }
    // кусок кода с какого-то сайта
    foreach (var item in testOnDigits)
    {
        if (!char.IsDigit(item))
        {
            return false; //если хоть один символ не число- "ложь"
        }
    }
    return true;
}

int? UserDigInput()
{
    string? stringInput = "";
    bool inputType = true;

    while (inputType)
    {
        Console.Write(">:");
        stringInput = Console.ReadLine()!;
        if (stringInput != "")
        {
            inputType = !СheckForNumbers(stringInput);//проверить число ли
        }
        else { return null; }// если пусто вернуть null

    }

    return Convert.ToInt32(stringInput);

}

Console.Clear();
Console.Write("Введите число строк массива");
int rowSize = Convert.ToInt32(UserDigInput());
Console.Write("Введите число столбцов массива");
int colSize = Convert.ToInt32(UserDigInput());


double[,] newArrayRandom = new double[rowSize, colSize];

for (int i = 0; i < rowSize; i++)
{
    for (int j = 0; j < colSize; j++)
    {
        newArrayRandom[i, j] = Convert.ToDouble(new Random().Next(-100, 100) / 10.0);
    }
}
Console.WriteLine();
for (int i = 0; i < rowSize; i++)
{
    for (int j = 0; j < colSize; j++)
    {
        Console.Write($"|{newArrayRandom[i, j]}".PadRight(5));
    }
    Console.Write("|\n");
}
