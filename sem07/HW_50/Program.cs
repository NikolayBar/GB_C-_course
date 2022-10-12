/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает 
значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4     17 -> такого числа в массиве нет

В связи с неясностью поставленой задачи делаем два варианта:
1.  Принимает значение от пользователя и ищет его в массиве 
    и выдает его позицию, или сообщает что такого элемента нет.
2.  Принимает от пользователя позицию элемента из двух чисел (строка,столбец), 
    проверяет наличие элемента с такими координатами и если введенные координаты не
    выходят из диапазона массива выдает значение элемента. В противном случае сообщает
    что такой позиции не существует. 
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
void PrintArray(int[,] array)
{
    string outData = "";
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            outData = $"| {array[i, j]}";
            Console.Write(outData.PadRight(4));
        }
        Console.Write("|\n");
    }
}

int[,] sourceArray = new int[3, 4]
{
    {1,4,7,2},
    {5,9,2,3},
    {8,4,2,4}
};

void SolutionFirst(int[,] array)
{
    Console.Write("ввести число");
    int value = Convert.ToInt32(UserDigInput());
    int count = 0;
    int rowSize = array.GetLength(0);
    int colSize = array.GetLength(1);
    string result = $"\nЗначение {value} в массиве не найдено";
    for (int i = 0; i < rowSize; i++)
    {
        for (int j = 0; j < colSize; j++)
        {
            if (array[i, j] == value)
            {
                count++;
                result = $"\nНайдено {count} знач. {value}\nкрайнее находится в ячейке: [{i},{j}])";
            }
        }
    }
    PrintArray(sourceArray);
    Console.WriteLine(result);
}

void SolutionSecond(int[,] array)
{
    Console.Write("Номер строки? ");
    int userRow = Convert.ToInt32(UserDigInput());
    Console.Write("Номер столбца? ");
    int userCol = Convert.ToInt32(UserDigInput());
    int arrRow = array.GetLength(0);
    int arrCol = array.GetLength(1);
    if (userRow >= 0 && userRow <= arrRow && userCol >= 0 && userCol <= arrCol)
    {
        Console.WriteLine($"Значение в ячейке [{userRow},{userCol}] равно {array[userRow, userCol]}");
    }
    else
    {
        Console.WriteLine($"Ячейка с координатами [{userRow},{userCol}] в массиве отсутствует!");
    }
    PrintArray(array);
}
Console.Clear();
Console.WriteLine("ВАРИАНТ 1.\nнайти число в массиве.");
SolutionFirst(sourceArray);
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("ВАРИАНТ 2.\nпоказать значение в массиве\nпо координатам.");
SolutionSecond(sourceArray);
