namespace Task06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long number;
            bool isEven = true;
            while(isEven)
            {
                Console.WriteLine("Введіть число для аналізу:");

                while (!long.TryParse(Console.ReadLine(), out number) || number < 0)
                {
                    Console.WriteLine("Введено некоректне значення. Спробуйте ще раз.");
                }
                // Я розумію якщо вввести число більше 19 цифр то вже й long не допоможе, але вирішив залишити так.

                if (number > 9999999999)
                {
                    Console.WriteLine("Занадто велике число...");
                    return;
                }

                if (number == 0)
                {
                    Console.WriteLine("Ви ввели нуль. Програма завершена.");
                    return;
                }

                while (number > 0)
                {
                    long temp = number;
                    int sum = 0;
                    int digitCount = 0;
                    bool isSeven = false;
                    int maxDigit = 0;
                    int counterPairDigits = 0;
                    while (temp > 0)
                    {
                        if (temp % 10 == 7)
                        {
                            isSeven = true;                            
                            number = 0;
                            break;
                        }
                        if (maxDigit < temp%10)
                        {
                            maxDigit = (int)(temp % 10);
                        }
                        sum += (int)(temp % 10);
                        if ((temp % 10) % 2 == 0)
                        {
                            counterPairDigits++;
                        }
                        temp /= 10;
                        digitCount++;

                    }
                    if (isSeven)
                    {
                        Console.WriteLine("Щасливе число 7.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Сума всіх чисел: {sum}, Максимальна цифра: {maxDigit}, Кількість парних цифр: {counterPairDigits}");
                        break;
                    }
                    
                }

            }       

            

            
        }
    }
}
