//Задача 23
//Напишите метод, который принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void CubeTab(int N)
{
    for(int i=1; i<=N; i++)
    {
        Console.WriteLine(i+"^3 = " + Math.Pow(i,3));
    }
}

Console.Clear();
Console.Write("Введите число до которого \nнужно вычислить таблицу кубов: ");

int Digit = Convert.ToInt32(Console.ReadLine());

CubeTab(Digit);
