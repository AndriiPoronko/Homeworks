namespace Task04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Завдання 4. Напишіть консольний застосунок мовою C#, для розв’язання задачі. Дано
            //матрицю 4x4.Потрібно обчислити, кількість елементів, які одночасно є більшими за
            //середнє арифметичне всіх елементів матриці та парними числами.

            int[,] matrix = new int[4, 4];
            int sum = 0;
            double average = 0;
            int counter = 0;
            Random random = new Random();
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = random.Next(-10, 10);
                    sum += matrix[i, j];
                    Console.Write($"{matrix[i, j]} ");
                }
            }
            average = sum / matrix.Length;

            foreach (int number in matrix)
            {
                if (number > average && number % 2 == 0)
                {
                    counter++;
                }
            }
            Console.WriteLine($"Результат: {counter}");

        }
    }
}
