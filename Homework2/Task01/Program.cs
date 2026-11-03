namespace Task01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ageLimit = 12;
            int heightMinLimit = 140;
            int heightMaxLimit = 200;
            int weightLimit = 120;

            Console.WriteLine("Введіть ваш вік:");
            if(!int.TryParse(Console.ReadLine(), out int personAge))
            {
                Console.WriteLine("Потрібно ввести число.");
                return;
            }
            Console.WriteLine("Введіть ваш зріст:");
            if(!int.TryParse(Console.ReadLine(), out int personHeight))
            {
                Console.WriteLine("Потрібно ввести число.");
                return;
            }
            Console.WriteLine("Введіть вашу вагу:");
            if(!int.TryParse(Console.ReadLine(), out int personWeight))
            {
                Console.WriteLine("Потрібно ввести число.");
                return;
            }

            if(personAge >= ageLimit)
            {
                if(personHeight >= heightMinLimit && personHeight <= heightMaxLimit)
                {
                    if(personWeight <= weightLimit)
                    {
                        Console.WriteLine("Ласкаво просимо на атракціон!");
                    }
                    else
                    { 
                        Console.WriteLine("Перевищення ліміту ваги"); 
                    }
                }
                else
                { 
                    Console.WriteLine("Зріст не відповідає нормам безпеки"); 
                }

            }
            else
            { 
                Console.WriteLine("Ви занадто молоді"); 
            }            

        }
    }
}
