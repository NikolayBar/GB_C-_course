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
void PrintArray(int[,] Array)
{
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            Console.Write($"|{Array[i, j]}");
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

void SolutionFirst(int[,] Array)
{
    Console.Clear();
    Console.Write("ввести число");
    int value = Convert.ToInt32(UserDigInput());
    int count = 0;
    int rowSize = Array.GetLength(0);
    int colSize = Array.GetLength(1);
    string result = $"\nЗначение {value} в массиве не найдено";
    for (int i = 0; i < rowSize; i++)
    {
        for (int j = 0; j < colSize; j++)
        {
            if (Array[i, j] == value)
            {
                count++;
                result = $"\nНайдено {count} знач. {value}\nкрайнее находится в ячейке: row {i}, col {j})";
            }
        }
    }
    PrintArray(sourceArray);
    Console.WriteLine(result);
}

SolutionFirst(sourceArray);
