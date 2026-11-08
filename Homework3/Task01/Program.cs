namespace Task01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Завдання 1. Напишіть консольний застосунок мовою C#, для розв’язання задачі. В
            //одновимірному масиві із 15 випадкових чисел(діапазон від -50 до 50). Визначити
            //мінімальний елемент та його індекс, але тільки серед тих, що стоять на парних позиціях.

            int[] numbers = new int[15];
            Random random = new Random();
            int minValue = 50;
            int index = 0;
            for (int i = 0;  i < numbers.Length; i++)
            {
                numbers[i] = random.Next(-50, 51);

                if(i%2 == 0 && numbers[i] < minValue)
                {
                    minValue = numbers[i];
                    index = i;
                }
            }            
            Console.WriteLine($"Мінімальне число: {minValue}, Індекс: {index}");

        }
    }
}
