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

double[] ArrMaterialNumber=ArrRandomNumber(5,0,80);
Console.WriteLine(string.Join("|",ArrMaterialNumber));

//int[] ArrMaterialNumber=ArrRandomNumber(5,0,100);
