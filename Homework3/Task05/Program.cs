namespace Task05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Завдання 5.Напишіть консольний застосунок мовою C#, для розв’язання задачі. Дано
            //одновимірний масив із 20 випадкових чисел. Знайдіть усі елементи, які є локальними
            //максимумами.Елемент вважається локальним максимумом, якщо він суворо більший
            //за своїх сусідів(ліворуч і праворуч).

            int[] numbers = new int[20];
            Random random = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(-50, 51);
                Console.Write($"{numbers[i]} ");
            }
            Console.WriteLine();
            for (int i = 1; i < numbers.Length - 1; i++)
            {
                if (numbers[i] > numbers[i - 1] && numbers[i] > numbers[i + 1])
                {
                    Console.WriteLine($"Елемент {numbers[i]} є локальним максимумом, з індексом: {i}");
                }
            }



        }
    }
}
