using System;

namespace lol{
        class program{

        public static void Main(string[] args)
        {
       
        //stirlingova formula
                int x;
            Console.WriteLine("Upisi broj: ");
            x = Convert.ToInt32(Console.ReadLine());
            double pi = 3.14;
            double e = 2.71;
            double stirling;
            stirling = (Math.Sqrt(2 * pi * x)) * Math.Pow((x / e), x);
            Console.WriteLine(stirling);
                
        }
    }
}
    
