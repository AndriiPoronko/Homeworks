namespace Task01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 1.Реалізувати алгоритм перевірки введених даних користувача та
            //автоматичного створення його мережевого імені(ніка).
            //Вхідні дані: Програма отримує рядок в якому записано ім’я, прізвище, e - mail та
            //пароль.
            //1.Генерація нікнейму - нікнейм користувача - це частина адреси E - mail, що
            //знаходиться ліворуч від символу @.
            //2.Валідація пароля - система повинна перевірити пароль на відповідність
            //наступним критеріям безпеки:
            //• довжина - не менше 4 - х символів.
            //• склад символів -обов'язкова наявність хоча б однієї цифри.
            //• мовні обмеження -категорично заборонено використовувати символи
            //кирилиці(пароль має містити лише латиницю, цифри та спецсимволи).
            //• Унікальність - пароль не повинен збігатися з отриманим нікнеймом
            //(перевірка має бути нечутливою до регістру, наприклад: Admin та admin
            //вважаються збігом).

            //3.Якщо пароль не проходить перевірку, програма має вивести конкретну причину
            //(або декілька) – помилка - занадто короткий пароль, помилка -пароль має
            //містити хоча б одну цифру, помилка: кирилиця заборонена, помилка: пароль не
            //може збігатися з нікнеймом.
            //4.Фінальне повідомлення - якщо всі умови виконано, вивести повідомлення у
            //форматі: [Ім’я][Прізвище] - Ви успішно зареєстровані під нікнеймом[Нікнейм].

            Console.WriteLine("Введіть Ім'я Прізвище e-mail та пароль");

            string[] parts = new string[4];
            string email = "";


            while (true) {
                string data = Console.ReadLine();
                parts = data.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

                if (parts.Length == 4)
                {
                    email = parts[2];
                    int atIndex = email.IndexOf("@");
                    int atLastIndex = email.LastIndexOf("@");                    
                    if(atIndex == atLastIndex && atIndex > 0 && atLastIndex < email.Length - 1 )
                    {
                        string stringAfterAt = email.Substring(atIndex + 1);
                        int dotIndex = stringAfterAt.IndexOf(".");                        
                        if (dotIndex > 0 && dotIndex < stringAfterAt.Length - 2)
                        {
                            break;
                        }
                        Console.WriteLine("Введіть Ім'я Прізвище e-mail та пароль, ви ввели некоректний EMAIL");
                        continue;
                    }
                    
                }
                Console.WriteLine("Введіть Ім'я Прізвище e-mail та пароль, рівно 4 значення");
            }
            string firstName = parts[0];
            string lastName = parts[1];
            string password = parts[3];
            string nickName = "";
            bool passwordError = false;
            bool isDigit = false;

            if (email.Contains("@"))
            {
                nickName = email.Substring(0, email.IndexOf("@"));               

            } 

            foreach(char letter in password)
            {
                if (letter >= '\u0400' && letter <= '\u04FF')
                {
                    Console.WriteLine($"Помилка пароля: кирилиця заборонена");
                    passwordError = true;
                    break;
                }
            }

            foreach (char letter in password)
            {
                if (char.IsDigit(letter))
                {
                    isDigit = true;
                    break;
                }        
                
            }
            if (!isDigit)
            {
                Console.WriteLine($"Помилка пароля: має містити хоча б одну цифру");
                passwordError = true;
            }
            if (password.Length < 4)
            {
                Console.WriteLine($"Помилка пароля: занадто короткий");
                passwordError = true;
            }
            if(password == nickName)
            {
                Console.WriteLine($"Помилка пароля: не може збігатися з нікнеймом");
                passwordError = true;
            }
            if(!passwordError)
            {
                Console.WriteLine($"{firstName} {lastName} - Ви успішно зареєстровані під нікнеймом {nickName}");
            }           
            
        }
    }
}
