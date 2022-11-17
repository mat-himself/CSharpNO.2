using System;
class test {
    public static void Main(){
        string a=Console.ReadLine();
        Double x=Convert.ToDouble(a);
        Console.WriteLine(Power(x));
         

    }
    private static Double Power(Double b){ 

    
    Double y=Math.Pow(b,2);
    Double z=Math.Pow(b,3);
    return y;
    return z;
    }
}