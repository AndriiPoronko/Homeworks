namespace Task06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Уявіть, що ви отримуєте дані з датчиків у вигляді зубчастого масиву int[][] sensors.
            //Деякі "місяці"(рядки) заповнені некоректно і містять значення - 100.Напишіть
            //консольний застосунок мовою C#, для розв’язання задачі.
            //1.Для кожного підмасиву визначте кількість некоректних записів.
            //2.Створіть «чисту» копію кожного підмасиву, використовуючи метод
            //екземпляра Clone().
            //3.У копії замініть усі - 100 на 0, використовуючи статичний метод Array.Clear() для
            //конкретних діапазонів(якщо помилки йдуть підряд) або циклом.
            //4.Використовуючи метод екземпляра CopyTo(), перенесіть дані з усіх підмасивів в
            //один загальний одновимірний масив «Річний звіт».
            int[][] numbers =
            {
                new int[] { 10, -100, 20 },
                new int[] { -100, -100, 5, 7 },
                new int[] { 5, 6, -100, -100 },
                new int[] { 3 }
            };
            int[][] copyNumbers = new int[numbers.Length][];
            int copyNumbersLength = 0;

            for(int i = 0; i < numbers.Length; i++)
            {
                int badNumbersCounter = 0;
                for(int j = 0; j < numbers[i].Length; j++)
                {
                    //Console.Write($"{numbers[i][j]} ");
                    if (numbers[i][j] == -100)
                    {
                        badNumbersCounter++;
                    }

                }
                copyNumbers[i] = (int[])numbers[i].Clone();

                Console.WriteLine();
                Console.WriteLine($"Не правильних данних в рядку з індексом {i}: {badNumbersCounter}");
                badNumbersCounter = 0;
            }

            for (int i = 0; i < copyNumbers.Length; i++)
            {
                int lenght = 0;
                for (int j = 0; j < copyNumbers[i].Length; j++)
                {
                    copyNumbersLength++;
                    if (copyNumbers[i][j] == -100)
                    {
                        lenght++;
                        continue;
                    }
                    if(lenght > 0)
                    {
                        Array.Clear(copyNumbers[i], j - lenght, lenght);
                        lenght = 0;
                    }                   

                }
                if(lenght > 0)
                {
                    Array.Clear(copyNumbers[i], copyNumbers[i].Length - lenght, lenght);
                }
            }

            int[] yearReport = new int[copyNumbersLength];
            int position = 0;

            for (int i = 0; i < copyNumbers.Length; i++)
            {
                copyNumbers[i].CopyTo(yearReport, position);
                position += copyNumbers[i].Length;
            }

            Console.Write("Array Numbers");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < numbers[i].Length; j++)
                {
                     Console.Write($"{numbers[i][j]} ");
                }
            }

            Console.WriteLine();
            Console.Write("Array copyNumbers");
            for (int i = 0; i < copyNumbers.Length; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < copyNumbers[i].Length; j++)
                {
                    Console.Write($"{copyNumbers[i][j]} ");
                }
            }

            Console.WriteLine();
            Console.WriteLine("Array yearReport");
            for (int i = 0; i < yearReport.Length; i++)
            {
                Console.Write($"{yearReport[i]} ");
            }


        }
    }
}
