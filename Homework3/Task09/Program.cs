namespace Task09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Дано одновимірний масив int[] array із 30 елементів.Напишіть консольний застосунок
            //мовою C#, для розв’язання задачі.
            //1.Заповніть масив випадковими числами та впорядкуйте його за допомогою
            //статичного Array.Sort().
            //2. 2.Користувач вводить число. Знайдіть його позицію за допомогою статичного
            //методу Array.BinarySearch().
            //3. 3.Якщо число знайдено, "виріжте" його з масиву: змініть розмір масиву на 1
            //менше за допомогою статичного Array.Resize(), зсунувши всі елементи після
            //знайденого вліво.

            int[] numbers = new int[30];
            Random random = new Random();

            for(int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(0, 31);
            }
            Array.Sort(numbers);

            int userNumber;
            Console.WriteLine("Введіть число:");
            while (!int.TryParse(Console.ReadLine(), out userNumber))
            {
                Console.WriteLine("Введіть правильні дані");
            }
            int pos = Array.BinarySearch(numbers, userNumber);

            if(pos >= 0)
            {
                for (int i = pos; i < numbers.Length - 1; i++)
                {
                    numbers[i] = numbers[i + 1];
                }
                Array.Resize(ref numbers, numbers.Length - 1);
                Console.WriteLine($"Число знайдено і вирізано, кількість елементі в масиві тепер - {numbers.Length}");
            }
            else
            {
                Console.WriteLine("Число в масиві не знайдено");
            }

            
        }
    }
}
