//Задача 4
//Программа на вход принимает число (num01), а на выходе показывает все чётные числа от 1 до num01.

int num01=11;
int curNum=1;

Console.Clear();

while(curNum<=num01)
{
    if(curNum%2 == 0)
    {
        Console.Write(curNum+" ");
    }
    curNum++;
}
