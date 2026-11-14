namespace Task03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 3.
            //Дано два натуральних числа. З'ясувати чи є хоча б одне з них паліндромом. 
            //(Визначити функцію, що дозволяє розпізнати числа-паліндроми).
            int a = 123445; 
            int b = 123454321;

            static bool IsNumberPalindrom(int number)
            {
                string stringNumber = number.ToString();
                char[] chars = stringNumber.ToCharArray();
                Array.Reverse(chars);
                string reverseNumber = new string(chars);

                return stringNumber == reverseNumber;
            }
            Console.WriteLine(IsNumberPalindrom(a) || IsNumberPalindrom(b));

        }
    }
}
