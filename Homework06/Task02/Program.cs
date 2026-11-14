using System.Net.NetworkInformation;

namespace Task02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 2.
            //Знайти периметр трикутника, заданого координатами своїх вершин.
            //(Визначити функцію для розрахунку довжини відрізка за координатами його кінців).
            double ax = 5;
            double ay = 5;
            double bx = 6;
            double by = -3;
            double cx = -4;
            double cy = -7;

            static double GetSegmentLenght(double x1, double y1, double x2, double y2)
            {
                double result = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
                return result;
            }
            static void CalculateTrianglePerimeter(double ab, double bc, double ac)
            {
                double result = ab + bc + ac;
                Console.WriteLine($"Периметр трикутника становить: {result}");
            }

            double ab = GetSegmentLenght(ax, ay, bx, by);
            double bc = GetSegmentLenght(bx, by, cx, cy);
            double ac = GetSegmentLenght(ax, ay, cx, cy);

            CalculateTrianglePerimeter(ab, bc, ac);
        }
    }
}
