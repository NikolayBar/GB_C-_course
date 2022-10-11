/*
Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. 
*/
int rowSize=5;
int colSize=5;
double sum=0.0;
int[,] twoDimensionalArray = new int[rowSize,colSize];
double[] resultArray = new double[colSize];

for(int j=0; j<colSize;j++)//заполнение массива и подсчет среднего арифметического
{
    for(int i=0;i< rowSize;i++)
    {
        twoDimensionalArray[i,j]= new Random().Next(0,10);
        sum=sum + Convert.ToDouble(twoDimensionalArray[i,j]);
    }
    resultArray[j]=sum/(rowSize);
    sum=0.0;
}

for(int i=0;i<rowSize;i++)//вывод заполненого массива
{
    for(int j=0;j<colSize;j++)
    {
        Console.Write($"|{twoDimensionalArray[i,j]}");        
    }
    Console.Write("|\n");
}

Console.WriteLine();
Console.Write("|");
Console.Write(String.Join("|",resultArray));//вывод среднего арифметического
Console.Write("|");