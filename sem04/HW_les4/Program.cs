/*
Есть магазин "Еда"
В магазине есть охранник
Охранник ведёт запись всех, кто заходит в магазин
Охранник ведёт запись всех, кто выходит из магазин
Зайти и выйти можно в целый час.
Выяснить в какой промежуток времени было больше всего
посетителей
Данные вводятся парами: приход-уход
Максимум 100 покупателей
Входные данные
10-12
11-13
9-12

Ответ
11-12
*/

int[] ListOfIncoming = new int[5]{5,6,7,9,8}; //список входящих
int[] ListOfOutput =   new int[5]{4,3,2,8,1}; // список выходящих

string[] WorkingTime = new string [5]{"9-10","10-11","11-12","12-13","13-14"};//рабочие часы
int max=0;

int[] PiopleCost()
{
    int[] PeopleInRoom = new int[5];
    for (int i=0; i<5;i++)
        {
           PeopleInRoom[i]= ListOfIncoming[i]-ListOfOutput[i];
        }
    return PeopleInRoom;
}

int FindMax(int[] A)
{
    max = A[0];
    int maxIndex=0;
    for(int i=0;i<5;i++)
    {
        if (A[i]>max) 
        {
            max=A[i];
            maxIndex=i;
        }
    }
    return maxIndex;
}

string MaxPeopleTime=WorkingTime[FindMax(PiopleCost())];


Console.Clear();
Console.WriteLine("Наибольшее количество посетителей ({0} чел.) ", max);
Console.WriteLine("находилось в магазине в период " + MaxPeopleTime + " час.");
