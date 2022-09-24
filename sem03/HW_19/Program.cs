//Задача 19
//Напишите метод, который принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

string PlndrTest(int InputDig)
{
    string Text = Convert.ToString(InputDig);
    string Result="не является палиндромом";
    string Txet="";
    foreach(char var in Text)
    {
        Txet= var + Txet;
    }

    if (Text == Txet) 
    {
        Result = "является палиндромом";
    }
    return Result;
}

Console.Clear();

int inpDigit=12421;//число по условию задачи онли.

Console.WriteLine("число "+ inpDigit +" " + PlndrTest(inpDigit));

