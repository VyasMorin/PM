using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;

namespace factorial
{
    class Program
    {
        static BigInteger faktorijel(int broj1)
        {

            BigInteger faktorijel = broj1;
            if (faktorijel == 0) return 1;
            for (int i = 1; i <= broj1 - 1; i++)
            {
                faktorijel = faktorijel * i;
            }
            return faktorijel;
        }
        static BigInteger StrilingMetoda(int a)
        {
            double Strilingfact = a;
            float e = 2.71F;
            float pi = 3.14F;
            Strilingfact = Math.Sqrt(2 * 3.14 * Strilingfact) * Math.Pow((Strilingfact / e), Strilingfact);
            BigInteger Striling2 = new BigInteger(Strilingfact);

            return Striling2;

        }
        static BigInteger BinomlaniKoeficijent(int broj1, int broj2)
        {
            int broj3 = broj1 - broj2;

            BigInteger[] faktorijeli = new BigInteger[3];


            faktorijeli[0] = broj1;
            faktorijeli[1] = broj2;
            faktorijeli[2] = broj3;
            BigInteger jedan = 1;


            for (int i = 1; i <= broj1 - 1; i++)
            {

                faktorijeli[0] = faktorijeli[0] * i;
            }
            for (int i = 1; i <= broj2 - 1; i++)
            {

                faktorijeli[1] = faktorijeli[1] * i;
            }
            for (int i = 1; i <= broj3 - 1; i++)
            {


                faktorijeli[2] = faktorijeli[2] * i;
            }
            BigInteger faktorijel4;

            if (faktorijeli[1] == 0 || faktorijeli[2] == 0) faktorijel4 = faktorijeli[0] / faktorijeli[0];
            else faktorijel4 = faktorijeli[0] / (faktorijeli[1] * faktorijeli[2]);

            return faktorijel4;

        }


        static void Main(string[] args)
        {
           
             Console.WriteLine("Upisi broj:");
             int number = Convert.ToInt32(Console.ReadLine());

             BigInteger fact = faktorijel(number);
             BigInteger Striling = StrilingMetoda(number);
             Console.WriteLine("Faktorijel broja " + number + " je " + fact);
             Console.WriteLine("Strilingovom metodom " + number + " je " + Striling);
             Console.WriteLine("Apsolutna razlika izmedu Faktorijela i Strlingove metode je " + BigInteger.Abs(fact - Striling));
             Console.ReadLine();
        }
    }
}
    
