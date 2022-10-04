/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

int[] ArrRandomNumber(int arrSize, int valueMin, int valueMax)// заполняем массив случайными числами
{
    int[] array = new int[arrSize];
    for (int i = 0; i < arrSize; i++) { array[i] = new Random().Next(valueMin, valueMax); }
    return array;
}

int[] ArrRandom = ArrRandomNumber(6, -20, 20);
int size = ArrRandom.Length;
int sum = 0;
for (int i = 1; i < size; i += 2) { sum += ArrRandom[i]; }

Console.Clear();
Console.Write("Массив : |");
Console.Write(string.Join("|", ArrRandom));
Console.Write($"|\nСумма элементов на нечётных позициях: {sum}\n ");