//Задача 19 Direct text Reverse text
//Напишите метод, который принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

string PlndrTest(int InputDig)
{
    string dirText = Convert.ToString(InputDig);
    string Result="не является палиндромом";
    string revText="";
    foreach(char var in dirText)
    {
        revText= var + revText;
    }

    if (dirText == revText) 
    {
        Result = "является палиндромом";
    }
    return Result;
}

Console.Clear();

//здесь должен быть код для ввода с клаваиатуры
//проверки введенного на соответствие условию задачи
// и при необходимости конвертации в int32
 
int inpDigit=12421;//число по условию задачи онли.

Console.WriteLine("число "+ inpDigit +" " + PlndrTest(inpDigit));

