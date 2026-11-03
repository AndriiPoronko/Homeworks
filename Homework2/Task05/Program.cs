namespace Task05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            double price = 0;
            int counter = 0;
            double result = 0;
            
            while (result < 5000)
            {
                Console.WriteLine("Введіть ціну товару:");
                while (!double.TryParse(Console.ReadLine(), out price) || price < 0 )
                {                  
                    Console.WriteLine("Введіть правильну суму товару.");
                }
                
                if (price == 0)
                {
                    Console.WriteLine($"Сума товарів у чеку {result}. Гарного дня, шановний клієнте!");
                    return;
                }

                if (price > 2000)
                {
                    string adminAnswer = "";
                    while (adminAnswer != "YES" && adminAnswer != "NO")
                    {
                        Console.WriteLine("Потрібне підтвердження адміністратора! Введіть YES/NO");
                        adminAnswer = Console.ReadLine().ToUpper();                        
                    }
                    if (adminAnswer == "NO")
                    {
                        continue;
                    }
                }

                counter++;
                if (counter%3 == 0)
                { 
                    price = price * 0.9; 
                }
                
                result += price;
                if(result >= 5000)
                {
                    Console.WriteLine($"Сума товарів у чеку {result}. Гарного дня, шановний VIP клієнте!");
                    return;
                }
                               
            }
        }
    }
}
