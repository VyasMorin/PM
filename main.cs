using System;

namespace Projekt {
    class Program {

        public static int faktorijel_loop(int n) {
            int faktorijel = 1;
            for (int i = 2; i <= n; i++) {
                faktorijel = faktorijel * i;
            }
            return faktorijel;
        }

        public static double faktorijel_stirling(double n) {
            return Math.Sqrt(2.0 * Math.PI * n) * Math.Pow((n / Math.E), n);
        }

        public static void Main(string[] args) {

            //stirlingova formula
            Console.WriteLine("Upisi broj: \n");
            int n = Convert.ToInt32(Console.ReadLine());
            int faktorijel = Program.faktorijel_loop(n);
            double stirling = Program.faktorijel_stirling(Convert.ToDouble(n));
            double apsolutna_greska = Math.Abs(Convert.ToDouble(faktorijel) - stirling);

            Console.WriteLine("'Klasicni' faktorijel broja " + n + " je " + faktorijel);
            Console.WriteLine("Stirlingovom formulom faktorijel broja " + n + " je " + stirling);
            Console.WriteLine("Apsolutna greska je " + apsolutna_greska);
            Console.WriteLine("Relativna greska je " + (Math.Abs((faktorijel - stirling) / faktorijel) * 100) + "%");

        }
    }
}
