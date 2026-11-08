namespace Task08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Квартальний рейтинг(Методи Array та Сортування). Напишіть консольний застосунок
            //мовою C#, для розв’язання задачі. Створіть зубчастий масив double[][] quarterlyGains,
            //де 4 підмасиви — це прибутки по місяцях у кожному кварталі.
            //1.У кожному кварталі відсортуйте значення прибутків за зростанням,
            //використовуючи статичний метод Array.Sort().
            //2.Використовуючи метод екземпляра GetUpperBound(0), знайдіть останній індекс
            //кожного місяця та виведіть найбільший прибуток(останній елемент після
            //сортування).
            //3.Створіть "архівну копію" всього зубчастого масиву через метод
            //екземпляра Clone().Змініть значення в оригіналі та перевірте, чи змінилися вони
            //в архіві.

            double[][] quarterlyGains = new double[4][];
            Random random = new Random();

            for(int i = 0; i < quarterlyGains.Length; i++)
            {
                quarterlyGains[i] = new double[random.Next(1, 20)];
                for(int j = 0; j < quarterlyGains[i].Length; j++)
                {
                    quarterlyGains[i][j] = random.Next(1, 1000);
                }
                Array.Sort(quarterlyGains[i]);
                int n = quarterlyGains[i].GetUpperBound(0);
                Console.WriteLine($"{quarterlyGains[i][n]}");
            }

            double[][] quarterlyGainsClone = (double[][])quarterlyGains.Clone();
            quarterlyGainsClone[0][0] = 111111111;
            Console.WriteLine($"{quarterlyGains[0][0]}");
            //Змінилися


        }
    }
}
