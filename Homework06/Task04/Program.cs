namespace Task04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 4.
            //Скласти програму для знаходження загальної кількості заданої літери у трьох заданих реченнях.
            //Визначити функцію для розрахунку кількості певної літери в реченні.

            string text = "Задача 4. Скласти програму для знаходження загальної кількості заданої літери у трьох заданих реченнях. Визначити функцію для розрахунку кількості певної літери в реченні.";
            char letter = 'Н';

            static int CountLetter(string text, char letter)
            {
                int count = 0;
                foreach(char x in text)
                {
                    if (char.ToLower(x) == char.ToLower(letter))
                    {
                        count++;
                    }
                }                
                return count;
            }

            Console.WriteLine($"Кількість літер {letter} становить: {CountLetter(text, letter)}");

        }
    }
}
