/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 

y = k1 * x + b1, 
y = k2 * x + b2; 

x = (b1-b2)/(k1-k2)

значения b1, k1, b2 и k2 задаются пользователем. 
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

//Значения заданые пользователем
double coordX;
double coordY;
double b1 = 2.0;
double b2 = 4.0;
double k1 = 5.0;
double k2 = 9.0;

double[,] introducedCoordinates = new double[2, 2]
{
    {b1,b2},
    {k1,k2}
};

string nm=" b";
for(int row=0;row<2;row++)
{
    for(int col=0;col<2;col++)
    {
        Console.Write($"{nm}{col+1} = {introducedCoordinates[row,col]}|");
        
    }
    nm=" k";
    Console.Write("\n");
}

void CalculateIntersectionPoint(double[,] inputCoord)
{
    double[] result = new double[2];
    coordX=(inputCoord[0,1]-inputCoord[0,0])/(inputCoord[1,0]-inputCoord[1,1]);
    coordY=(inputCoord[1,0]*coordX)+inputCoord[0,0];
}

CalculateIntersectionPoint(introducedCoordinates);
Console.Clear();
Console.WriteLine($"\n k1*x + b1 = {introducedCoordinates[1,0]*coordX+introducedCoordinates[0,0]}");
Console.WriteLine($"\n k2*x + b2 = {introducedCoordinates[1,1]*coordX+introducedCoordinates[0,1]}");
Console.WriteLine($"точка пересечения в координатах х={coordX} , y={coordY}");
