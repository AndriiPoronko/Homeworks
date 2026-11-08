namespace Task07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Дано прямокутну матрицю int[,] martix. Напишіть консольний застосунок мовою C#, для розв’язання задачі.
            //1.Напишіть алгоритм, який за допомогою методу
            //екземпляра GetLength(0) та GetLength(1)проходить по кожному рядку.
            //2.Скопіюйте кожен рядок у тимчасовий одновимірний масив(використовуйте
            //статичний Array.Copy()).
            //3.Застосуйте до тимчасового масиву статичний метод Array.Reverse().
            //4.Поверніть дані назад у матрицю. Таким чином ви отримаєте дзеркальне
            //відображення масиву.
            //5.Виведіть останній індекс індекс елементу із значенням 500 у кожному рядку,
            //використовуючи статичний Array.LastIndexOf().

            int[,] matrix = new int[10, 10];
            Random random = new Random();

            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.WriteLine();
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = random.Next(0, 501);
                    Console.Write($"{matrix[i, j]} ");
                }
            }

            Console.WriteLine();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] temp = new int[matrix.GetLength(1)];
                //Array.Copy(matrix, i * matrix.GetLength(1), temp, 0, matrix.GetLength(1));
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    temp[j] = matrix[i, j];
                }
                Array.Reverse(temp);
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = temp[j];                    
                }

                Console.WriteLine($"{i+1}. {Array.LastIndexOf(temp, 500)}");
            }

            //for (int i = 0; i < matrix.GetLength(0); i++)
            //{
            //    Console.WriteLine();
            //    for (int j = 0; j < matrix.GetLength(1); j++)
            //    {
            //        Console.Write($"{matrix[i, j]} ");
            //    }
            //}
        }
    }
}
