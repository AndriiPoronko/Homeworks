using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Task03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 3: Для обробки довгого повідомлення при модерації чату необхідно видалити
            //зайве та замінити заборонені слова.

            //1.Програма отримує довгий рядок тексту.
            //2.Створіть StringBuilder на основі цього рядка, але відразу встановіть його
            //Capacity рівним довжині вхідного рядка + 50(запас для редагування).
            //3.Реалізуйте наступні кроки редагування:
            //• очищення - видаліть усі цифри з тексту
            //• цензура - знайдіть у тексті слово "пароль"(або будь - яке інше за Вашим
            //вибором) і замініть його на[БЕЗПЕЧНО].
            //• форматування - вставте на початок тексту рядок "LOG: " та поточну дату
            //(використовуйте Insert, DataTime).
            //• оптимізація - наприкінці виведіть у консоль значення Length та Capacity
            //вашого об'єкта, щоб побачити, чи вистачило виділеного місця.

            //Приклад роботи:
            //Введення: "Привіт! Мій пароль 1234. Сьогодні я оновив налаштування."
            //Вивід: " LOG: 07.11.2026 Привіт! Мій пароль [ПРИХОВАНО] . Сьогодні я оновив
            //налаштування.
            //Статистика: Length: 58, Capacity: 94

            Console.WriteLine("Введіть повідомлення");
            string message = Console.ReadLine();
            StringBuilder sb = new StringBuilder(message, message.Length + 50);

            for(int i = 0; i < sb.Length; i++)
            {
                if (char.IsDigit(sb[i]))
                {
                    sb.Remove(i, 1);
                    i--;
                }
            }
            sb.Replace("пароль", "[ПРИХОВАНО]");
            sb.Insert(0, "Log: ").Insert(5, DateTime.Now.ToString("dd.MM.yyyy") + " ");         
            Console.WriteLine(sb);
            Console.WriteLine($"Статистика: Length: {sb.Length}, Capacity: {sb.Capacity}");
        }
    }
}
