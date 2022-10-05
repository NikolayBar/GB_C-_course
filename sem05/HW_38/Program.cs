/*
Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива. material number
[3 7 22 2 78] -> 76
*/

double[] ArrRandomNumber(int arrSize, int valueMin, int valueMax)// заполняем массив случайными числами
{
    double[] array = new double[arrSize];
    for (int i = 0; i < arrSize; i++) { array[i] = new Random().Next(valueMin, valueMax); }
    return array;
}

double FindMax(double[] ArrInput)//поиск максимального знач.
{
    int size = ArrInput.Length;
    double maxValue = ArrInput[0];
    for (int i = 0; i < size; i++)
    {
        if (ArrInput[i] > maxValue) { maxValue = ArrInput[i]; }
    }
    return maxValue;
}

double FindMin(double[] ArrInput)//поиск минимального знач.
{
    int size = ArrInput.Length;
    double minValue = ArrInput[0];
    for (int i = 0; i < size; i++)
    {
        if (ArrInput[i] < minValue) { minValue = ArrInput[i]; }
    }
    return minValue;
}


double[] ArrMaterialNumber = ArrRandomNumber(5, 0, 80);

double maxValue = FindMax(ArrMaterialNumber);
double minValue = FindMin(ArrMaterialNumber);

Console.Clear();
Console.WriteLine(string.Join("|", ArrMaterialNumber));
Console.WriteLine($"{maxValue} - {minValue} = {maxValue - minValue}");

