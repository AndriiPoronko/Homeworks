namespace Task02
{
    internal class Program
    {
        static void Main(string[] args)
        {        
            Console.WriteLine("Введіть номер місяця:");
            if (!int.TryParse(Console.ReadLine(), out int numberMonth))
            {
                Console.WriteLine("Потрібно ввести число.");
                return;
            }

            switch (numberMonth)
            {
                case 1:
                    Console.WriteLine("Січень, 31 день");
                    break;
                case 2:
                    Console.WriteLine("Введіть рік:");
                    int year = int.Parse(Console.ReadLine());
                    if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0))
                    { 
                        Console.WriteLine("Лютий, 29 днів"); 
                    }
                    else
                    { 
                        Console.WriteLine("Лютий, 28 днів");
                    }
                    break;
                case 3:
                    Console.WriteLine("Березень, 31 день");
                    break;
                case 4:
                    Console.WriteLine("Квітень, 30 днів");
                    break;
                case 5:
                    Console.WriteLine("Травень, 31 день");
                    break;
                case 6:
                    Console.WriteLine("Червень, 30 днів");
                    break;
                case 7:
                    Console.WriteLine("Липень, 31 день");
                    break;
                case 8:
                    Console.WriteLine("Серпень, 31 день");
                    break;
                case 9:
                    Console.WriteLine("Вересень, 30 днів");
                    break;
                case 10:
                    Console.WriteLine("Жовтень, 31 день");
                    break;
                case 11:
                    Console.WriteLine("Листопад, 30 днів");
                    break;
                case 12:
                    Console.WriteLine("Грудень, 31 день");
                    break;
                default:
                    Console.WriteLine("Номер місяця має бути від 1 до 12");
                    break;
            }
        }
    }
}
