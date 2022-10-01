/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве. The number of even numbers
[345, 897, 568, 234] -> 2
*/

int[] ArrThreeDigNum(int arrSize)// заполняем массив трехзначными числами
{
    int[] array= new int[arrSize];
    for(int i=0;i<arrSize;i++)
    {
        array[i]= new Random().Next(100,1000);
    }
    return array;
}

double NumOfEvenNum(int[] Array)// считаем четные числа
{
int size = Array.Length;
int res=0;
for(int i=0; i<size;i++)
{
    if(Array[i]%2==0) res++;
}
return res;
}

int size=6;// размер массива
int[] arrRes=ArrThreeDigNum(size);

Console.Clear();
Console.WriteLine("в массиве: " + String.Join("|", arrRes));
Console.WriteLine("Из {1} чисел четных {0}", NumOfEvenNum(arrRes),size);
