
//Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
//или сообщает, что третьей цифры нет.

Console.Clear();

int initNumber=78;
string StrNumber=initNumber.ToString();

if (StrNumber.Length<3)
{
    Console.Write("в числе "+ StrNumber + " меньше трех цифр.");
}
else
{
    Console.Write("в числе "+ StrNumber + " третья цифра слева - "+ StrNumber.Substring(2,1));
}





