using System;
class test{ 


public static void Main(){
    string x=Console.ReadLine();
int a=Convert.ToInt32(x);
calculator(a);

}
private static void calculator(int z)
{ 
    int years,months,weeks;
    years=z/365;
    z=z%365;

    months=z/30;
    z=z%30;

    weeks=z/7;
    z=z%7;

    Console.WriteLine(years);
    Console.WriteLine(months);
    Console.WriteLine(weeks);
    Console.WriteLine(z);
}
}