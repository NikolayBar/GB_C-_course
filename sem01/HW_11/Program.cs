int num01=-9;
int num02=-9;

if (num01 != num02)
{
    if(num01>num02)
    {
        Console.WriteLine("max: "+num01+",  min: "+num02);
    }
    else
    {
        Console.WriteLine("max: "+num02+",  min: "+num01);
    }
}
else
{
    Console.WriteLine(num01+" == "+num02);
}
