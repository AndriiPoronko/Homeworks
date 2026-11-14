namespace Task01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 1.
            //Дано основи та висоти двох рівнобедрених трапецій.Знайти суму їх периметрів.
            //(Визначити функцію для розрахунку периметра рівнобедреної трапеції за основами та висотою)
            double base1ВС = 10;
            double base1AD = 15;
            double height1 = 7;
            double base2BC = 4;
            double base2AD = 10;
            double height2 = 5;

            static double CalculateTrapezoidPerimeter(double shortBase, double longBase, double height)
            {
                double baseAE = (longBase - shortBase) / 2;
                double baseAB = Math.Sqrt(baseAE * baseAE + height * height);
                double result = shortBase + longBase + baseAB * 2;
                return result;
            }
            static void SumTrapezoidPerimeters(double a, double b)
            {
                double result = a + b;
                Console.WriteLine($"Сума периметрів трапецій дорівнює:{result}");
            }
            double perimeter1 = CalculateTrapezoidPerimeter(base1ВС, base1AD, height1);
            double perimeter2 = CalculateTrapezoidPerimeter(base2BC, base2AD, height2);
            SumTrapezoidPerimeters(perimeter1, perimeter2);

        }
    }
}
