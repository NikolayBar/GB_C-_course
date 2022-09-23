//Напишите метод, который принимает на вход координаты двух точек 
//и находит расстояние между ними в 3D пространстве.


double DistansAB(int[] A, int[] B)
{
double sum=0;
for(int i=0; i<3; i++)
{
    sum = sum + Math.Pow((B[i]-A[i]),2);
}
return Math.Sqrt(sum);
}

int[] A = new int[]{7,-5,0};
int[] B = new int[]{1,-1,9};

Console.Clear();
Console.WriteLine(DistansAB(A,B).ToString("#.00"));
