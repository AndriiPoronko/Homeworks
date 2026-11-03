namespace Task03
{
    internal class Program
    {
        enum Quarter
        {
            First = 1,
            Second,
            Third,
            Fourth,
            Origin,
            OnAxis
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть кординату X:");
            if (!double.TryParse(Console.ReadLine(), out double x))
            {
                Console.WriteLine("Потрібно ввести число.");
                return;
            }
            Console.WriteLine("Введіть кординату Y:");
            if (!double.TryParse(Console.ReadLine(), out double y))
            {
                Console.WriteLine("Потрібно ввести число.");
                return;
            }

            Quarter result = (x, y) switch
            {
                (0, 0) => Quarter.Origin,
                (0, _) or (_, 0) => Quarter.OnAxis,
                ( > 0, > 0) => Quarter.First,
                ( < 0, > 0) => Quarter.Second,
                ( < 0, < 0) => Quarter.Third,
                ( > 0, < 0) => Quarter.Fourth
            };

            double distance = Math.Sqrt(x * x + y * y);
            if(distance > 100)
            {
                Console.WriteLine("Точка занадто далеко");
            }
            else
            {
                Console.WriteLine($"Точка знаходиться в {result} чверті. Відстань від початку координат до точки: {distance}");
            }
            

        }
    }

}