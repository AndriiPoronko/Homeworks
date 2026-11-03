namespace Task04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double price1, price2, price3;
            int day;
            Console.WriteLine("ВВедіть ціну першого товару:");
            while (!double.TryParse(Console.ReadLine(), out price1) || price1 <= 0)
            {
                Console.WriteLine("Введіть правильно суму товару.");
            }
            Console.WriteLine("ВВедіть ціну другого товару:");
            while (!double.TryParse(Console.ReadLine(), out price2) || price2 <= 0)
            {
                Console.WriteLine("Введіть правильно суму товару.");
            }
            Console.WriteLine("ВВедіть ціну третього товару:");
            while (!double.TryParse(Console.ReadLine(), out price3) || price3 <= 0)
            {
                Console.WriteLine("Введіть правильно суму товару.");
            }
            Console.WriteLine("ВВедіть день тижня:");
            while (!int.TryParse(Console.ReadLine(), out day) || day < 1 || day > 7)
            {
                Console.WriteLine("Введіть правильно день тижня (1-7).");
            }

            double sum = price1 + price2 + price3;
            double average = sum / 3;
            double result;

            switch (day)
            {
                case 1: 
                    result = sum * 1.05;
                    break;
                case 7:
                    result = sum * 0.85;
                    break;
                default:
                    result = sum;
                    break;
            }
            Console.WriteLine($"Сума товарів у чеку {result}, Середня вартість товару без знижки {average}");
        }
    }
}
