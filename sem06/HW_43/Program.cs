/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, 
y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

Console.Clear();
Console.Write("Найти точку пересечения двух \nпрямых ");
Console.WriteLine("заданых уравнениями:\n\ny = k1 * x + b1\ny = k2 * x + b2\n");
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

double[,] userDataRequest()
{
    string[,] PosName = new string[2, 2]
    {
    {"b1","b2"},
    {"k1","k2"}
    }; 
    
    double[,] ArrUserData = new double[2, 2];

    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            Console.Write($"{j+1}я прямая, значение {PosName[i, j]}");
            ArrUserData[i, j] = Convert.ToDouble(UserDigInput());
        }
    }
    return ArrUserData;
}

double[,] dataEnteredUser = userDataRequest();

double coordX = 0.0;
double coordY = 0.0;
string Answer;

void CalculateIntersectionPoint(double[,] inputCoord)
{
    if (inputCoord[1, 0] != inputCoord[1, 1])
    {
        coordX = (inputCoord[0, 1] - inputCoord[0, 0]) / (inputCoord[1, 0] - inputCoord[1, 1]);
        coordY = (inputCoord[1, 0] * coordX) + inputCoord[0, 0];
        Answer = $"Прямые пересекаются в точке X={coordX} / Y={coordY}).";
    }
    else
    {
        if (inputCoord[0, 1] == inputCoord[0, 0])
        {
            Answer = "Прямые совпадают";
        }
        else
        {
            Answer = "Прямые паралельны";
        }
    }
}

CalculateIntersectionPoint(dataEnteredUser);

Console.WriteLine();
Console.WriteLine(Answer);
