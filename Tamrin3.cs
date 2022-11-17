using System;
using System.ComponentModel;

class test
{
    public static void Main()
    {
  int temp = 0;
        
string a = Console.ReadLine();
  if (a == "0")
{
            
a = Console.ReadLine();
}
      
string b = Console.ReadLine();
if (b == "0")
{
            
b = Console.ReadLine();
}
int x = Convert.ToInt32(a);
int y = Convert.ToInt32(b);
if (y > x)
{
temp = y;
y = x;
x = temp;
}
Console.Write("KMM=");
Console.WriteLine(KMM(x, y));
Console.Write("BMM=");
Console.Write(BMM(x, y));
}
private static double KMM(int x, int y)
{
double m =0;
int n = 0;
do
{
n++;
m = x * n;
}
while (m % y != 0);
return m;
}
private static double BMM(int x, int y)
{
int m = 0;
int n = 0;
int p = 0;
do
{
m++;
if (x % m == 0)
{
n = x / m;
if (y % n == 0)
{
p = n;
}
}
}
while ((y % m) == 0);
if(p == 0)
{
Console.Write("no bmm   ");
}
return (p);
}
}