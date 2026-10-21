namespace Task05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int y = int.Parse(Console.ReadLine());
            double avg = x + (double)y / 2;
            Console.WriteLine($"Average = {avg}");
        }
    }
}
