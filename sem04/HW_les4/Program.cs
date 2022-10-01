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

//Заполнение списка пришло/ушло охранником
int[] ListOfIncoming = new int[5]; //список входящих
int[] ListOfOutput =   new int[5]; // список выходящих

int RndPeople(int maxPeople)//случайное число пришел/ушел
{
    int result = new Random().Next(1,maxPeople);
    return result;
}

int oldVisitors = 0;// покупателей при открытии
for (int i=0;i<5;i++) // заполняем списки пришел/ушел
{
    ListOfIncoming[i]= RndPeople(100-oldVisitors);// зашло покупателей
    ListOfOutput[i]= RndPeople(ListOfIncoming[i] + oldVisitors);//вышло покупателей
    oldVisitors=ListOfIncoming[i]-ListOfOutput[i];// осталось в магазине
    if(oldVisitors<0) oldVisitors=0;// проверка на отрицательный результат
}
// список заполнен

string[] WorkingTime = new string [5]{"9-10","10-11","11-12","12-13","13-14"};//рабочие часы
int max=0;// максимальное число покупателей 

int[] NumberOfVisitorsPerHours()// число покупателей по часам
{
    int[] PeopleInRoom = new int[5];
    for (int i=0; i<5;i++)
        {
           PeopleInRoom[i]= ListOfIncoming[i]-ListOfOutput[i];//разница вошедших/ушедших
           if (i>0) PeopleInRoom[i]=PeopleInRoom[i]+PeopleInRoom[i-1];// остались с прошлого часа
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

string MaxPeopleTime=WorkingTime[FindMax(NumberOfVisitorsPerHours())];


Console.Clear();
Console.WriteLine("Наибольшее количество посетителей ({0} чел.) ", max);
Console.WriteLine("находилось в магазине в период " + MaxPeopleTime + " час.");
Console.WriteLine();
Console.WriteLine(String.Join("|", ListOfIncoming)+ " - зашло покупателей");
Console.WriteLine(String.Join("|", ListOfOutput) + " - вышло покупателей");
