using System;
class test
{
public static void Main()
    {
int a=Convert.ToInt32(Console.ReadLine());
int b=Convert.ToInt32(Console.ReadLine());
int c=Convert.ToInt32(Console.ReadLine());
Risheha(a,b,c);
}
private static void Risheha(int x,int y,int z)
    {
double delta = (Math.Pow(y, 2)) - (4 * x * z);
if(delta > 0)
{
 double javab_1 = (-y + Math.Sqrt(delta)) / 2 * x;
double javab_2 = (-y - Math.Sqrt(delta)) / 2 * x;
Console.Write("moadele 2 rishe darad");
 Console.Write("rishe 1:");
 Console.Write(javab_1);
Console.Write("   rishe 2:");
 Console.Write(javab_2);
 }
if(delta == 0)
 {
 double javab_1 = -y / 2 * x;
Console.Write("moadele 1 rishe darad:");
Console.WriteLine(javab_1);
 }
if(delta < 0)
{
Console.WriteLine("moadele rishe nadarad");
}
}
}