using System.Text;

namespace Task02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 2.Ви пишете модуль для роботи з базою даних.Вам потрібно зібрати один
            //великий запит(рядок) із багатьох дрібних частин, які вводить користувач.
            //Використання звичайного +тут заборонено через велику кількість ітерацій.
            //1.Користувач вводить назву таблиці(наприклад, Users).
            //2.Користувач по черзі вводить назви колонок(наприклад, ID, Name, Age, Email),
            //поки не введе слово "stop".
            //3.Використовуючи StringBuilder, сформуйте рядок запиту за шаблоном: SELECT
            //[Колонки] FROM[Таблиця] WHERE IsActive = 1;
            //            4.Додаткові умови:
            //• Між назвами колонок мають бути коми та пробіли.
            //• Після останньої колонки коми бути не повинно(врахуйте це при
            //побудові).
            //• Якщо користувач ввів назву колонки Password, програма має автоматично
            //замінити її на MASKED_PASSWORD.

            //Приклад виводу: SELECT ID, Name, MASKED_PASSWORD FROM Users WHERE
            //IsActive = 1;

            Console.WriteLine("Введіть назву таблиці:");
            StringBuilder sb = new StringBuilder();
            string table = Console.ReadLine().ToUpper();
            while (string.IsNullOrWhiteSpace(table))
            {
                Console.WriteLine("Назва не може бути порожньою. Спробуйте ще раз:");
                table = Console.ReadLine();
            }
            sb.Append("SELECT ");
            string column;
            while (true)
            {
                Console.WriteLine("Введіть назву колонки:");
                column = Console.ReadLine().ToUpper();
                if (column == "STOP" && sb.Length > 7)
                {
                    sb.Length -= 2;
                    break;
                }
                if(column == "PASSWORD")
                {
                    sb.Append("MASKED_PASSWORD, ");
                    continue;
                }
                if(column != "STOP")
                {
                    sb.Append(column).Append(", ");
                }                
            }
            sb.Append(" FROM ").Append(table).Append(" WHERE IsActive = 1;");
            Console.WriteLine($"{sb}");
            
        }
    }
}
