namespace Task03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Завдання 3. Напишіть консольний застосунок мовою C#, для розв’язання задачі.
            //Користувач вводить два індекси: start та end.Програма має підрахувати кількість
            //додатних елементів у одновимірному масиві, але тільки в межах цього діапазону
            //(від start до end включно).
            int[] numbers = new int[100];
            int start;
            int end;
            int minIndex = 0;
            int maxIndex = numbers.Length - 1;            
            int counter = 0;
            Random random = new Random();

            Console.WriteLine($"Введіть індекс початку від {minIndex} до {maxIndex}");
            while (!int.TryParse(Console.ReadLine(), out start) || start < minIndex || start > maxIndex){
                Console.WriteLine("Ви ввесли некоректні дані, Спробуйте ще:");
            }
            Console.WriteLine("Введіть індекс кінця");
            while (!int.TryParse(Console.ReadLine(), out end) || end < start || end > maxIndex)
            {
                Console.WriteLine("Ви ввесли некоректні дані, Спробуйте ще:");
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(-50, 51);
                Console.Write($"{numbers[i]} ");
            }

            for (int i = start; i <= end; i++)
            {
                if (numbers[i] > 0)
                {
                    counter++;
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Кідбкість додатніх елементів становить: {counter}");

        }
    }
}
