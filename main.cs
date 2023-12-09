using System;

namespace Projekt {
    class Program {

        static long CalculateFactorialLoop(int n) {
            if (n < 0) {
                throw new ArgumentException("Input must be a non-negative integer.");
            }
            
            long factorial = 1;
            for (int i = 1; i <= n; i++) {
                factorial *= i;
            }

            return factorial;
        }

        public static double CalculateFactorialStirling(double n) {
            if (n < 0) {
                throw new ArgumentException("Input must be a non-negative integer.");
            }
            return Math.Sqrt(2.0 * Math.PI * n) * Math.Pow((n / Math.E), n);
        }

        public static void Main(string[] args) {

            //stirlingova formula
            Console.WriteLine("Upisi broj: \n");
            int n = Convert.ToInt32(Console.ReadLine());
            long faktorijel = Program.CalculateFactorialLoop(n);
            double stirling = Program.CalculateFactorialStirling(Convert.ToDouble(n));
            double apsolutna_greska = Math.Abs(Convert.ToDouble(faktorijel) - stirling);

            Console.WriteLine("'Klasicni' faktorijel broja " + n + " je " + faktorijel);
            Console.WriteLine("Stirlingovom formulom faktorijel broja " + n + " je " + stirling);
            Console.WriteLine("Apsolutna greska je " + apsolutna_greska);
            Console.WriteLine("Relativna greska je " + (Math.Abs((faktorijel - stirling) / faktorijel) * 100) + "%");

        }
    }
}
