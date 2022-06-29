using System;

class URI
{

    static void Main(string[] args)
    {
         double R , A;
         R = Convert.ToDouble(Console.ReadLine());
        
         A = 3.1416 * ( R * R);
         Console.WriteLine("A=" + A.ToString("0.0000"));
         Console.ReadKey();
    }

}