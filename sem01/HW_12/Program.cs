//Задача 2
//Программа принимает на вход три числа и выдаёт максимальное из этих чисел.
int num01=22;
int num02=3;
int num03=9;
int max=0;

if (num01>num02)
{
    max=num01;
}
else
{
    max=num02;
}
if (num03>max)
{
    max=num03;
}
Console.WriteLine("максимальное значение: "+max);
