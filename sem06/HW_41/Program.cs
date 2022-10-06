/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
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
        stringInput = Console.ReadLine()!;
        if (stringInput != "")
        {
            inputType = !СheckForNumbers(stringInput);//проверить число ли
        }
        else { return null; }// если пусто вернуть null

    }

    return Convert.ToInt32(stringInput);

}

int MoreThanZeroNumbers(int?[] ArrayInp)
{
    int notZero = 0;
    int size = ArrayInp.Length;
    for (int i = 0; i < size; i++)
    {
        if (ArrayInp[i] > 0) { notZero++; }
    }
    return notZero;
}

bool resultOfTheInput = true;
int?[] listOfAnswers = new int?[1];
int i = 0;
Console.Clear();
Console.Write("\nВведи любое число \n(для завершения > пустое значение)\n");
while (resultOfTheInput)
{
    Console.Write(">: ");
    int? A = UserDigInput();
    if (A != null)
    {
        listOfAnswers[i] = A;
        Array.Resize(ref listOfAnswers, listOfAnswers.Length + 1);// добавить длину массиву
        i++;
    }
    else
    {
        resultOfTheInput = false;
    }
}
Console.WriteLine();
Console.Write($"В массиве:{string.Join("|", listOfAnswers)} чисел больше нуля - ");
Console.Write(MoreThanZeroNumbers(listOfAnswers));
