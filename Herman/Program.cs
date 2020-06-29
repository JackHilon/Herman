using System;

namespace Herman
{
    class Program
    {
        static void Main(string[] args)
        {
            // Herman
            // https://open.kattis.com/problems/herman 
            // Manhattan Cirle (circle in Minkowski geometery)
            // Manhattan distance is the taxicab distance.

            int myRadius = EnterRadius();

            Console.WriteLine(String.Format("{0:0.000000}", CircleEuclidianArea(myRadius)));
            Console.WriteLine(String.Format("{0:0.000000}", CircleTaxicabArea(myRadius)));
        }
        private static double CircleTaxicabArea(int radius)
        {
            // A Taxicab Circle is a square (radius= half Diagonal).
            double r = (double)radius;
            double area = 4 * (0.5 * r * r);
            return area;
        }
        private static double CircleEuclidianArea(int radius)
        {
            // A Euclidian Circle is a circle.
            double r = (double)radius;
            double area = Math.PI * r * r;
            return area;
        }

        private static int EnterRadius()
        {
            int a = 0;
            try
            {
                a = int.Parse(Console.ReadLine());
                if (a <= 0 || a > 10000)
                    throw new ArgumentException();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return EnterRadius();
            }
            return a;
        }
    }
}
