namespace Task02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Завдання 2. Напишіть консольний застосунок мовою C#, для розв’язання задачі. В
            //одновимірному масиві з n елементів Визначити перше число та його індекс, яке є
            //від’ємним і одночасно кратним 3(наприклад, -9 або - 12).
            int n = 15;
            int[] numbers = new int[n];
            Random random = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(-50, 51);
                Console.Write($"{numbers[i]},");
            }
            
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 0 && numbers[i] % 3 == 0)
                {
                    Console.WriteLine($"Перше відємне число кратне 3: {numbers[i]} індекс числа: {i} ");
                    return;
                }
            }
            Console.WriteLine($"Відємне число не було знайдено");
            
            
        }
    }
}
