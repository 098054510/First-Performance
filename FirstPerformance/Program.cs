using System;

namespace FirstPerformance
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, Delta, x1, x2;

            string[] vet = Console.ReadLine().Split(' ');

            a = double.Parse(vet[0]);
            b = double.Parse(vet[1]);
            c = double.Parse(vet[2]);

            Delta = b * b - 4 * a * c ;

            if (a == 0.0 || Delta <= 0.0)
            {
                Console.WriteLine("IMPOSSIVEL CALCULAR");
            }
            else
            {
                x1 = (-b + Math.Sqrt(Delta)) / (2.0 * a);
                x2 = (-b - Math.Sqrt(Delta)) / (2.0 * a);

                Console.WriteLine("X1 = " + x1);
                Console.WriteLine("X2 = " + x2);

                Console.ReadLine();
            }

        }
    }
}
