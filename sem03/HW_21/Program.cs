//Напишите метод, который принимает на вход координаты двух точек 
//и находит расстояние между ними в 3D пространстве.

double[] InputCoord()
{
    string[] nameCoord= {"X","Y","Z"};// наменование координат
    string tmpInput = string.Empty;// временное строковое значение координаты
    double[] meanCoord= new double[3];// массив для координат точек
    for(int i=0;i<3;i++)
    {
        Console.Write("Координата {0}:", nameCoord[i]);
        tmpInput=Console.ReadLine()!;
        // добавить проверку введенного значения
        meanCoord[i]=Convert.ToDouble(tmpInput);
    }

    return meanCoord;
}

double DistansXYZ(double[] dotA, double[] dotB)
{
double sum=0;
for(int i=0; i<3; i++)
{
    sum = sum + Math.Pow((dotB[i]-dotA[i]),2);
}
return Math.Sqrt(sum);
}

Console.Clear();
Console.WriteLine("Положение начальной точки:");
double[] startDot=InputCoord();

Console.WriteLine("Положение конечной точки:");
double[] endDot=InputCoord();


Console.Write("Расстояние между точками = ");
Console.Write(DistansXYZ(startDot,endDot).ToString("#.00"));
