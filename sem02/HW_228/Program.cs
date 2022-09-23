//Задача 228: Напишите программу, которая принимает 
//на вход семь чисел, и находит их среднее арифметическое
Console.Clear();
int size=7;

int[] Arr01 = new int[size];
double sum =0;
for(int i=0; i<size;i++)
{
    Arr01[i]= new Random().Next(1,70);
    Console.Write(Arr01[i]+" ");
    sum = sum + Arr01[i];
}
Console.Write("\n Среднее арифметическое:" + sum/Arr01.Length);
