using System;

public class Start
{
    public static void Main(string[] args)
    {
        int count = 3;
        Random rnd = new Random();
        int value = rnd.Next(0, 10);
        while (count > 0) { 
            Console.Write("Введите число: ");
            int value_user = Convert.ToInt32(Console.ReadLine());
            count--;
            if (value > value_user)
            {
                Console.WriteLine("Загаданное чилсо больше!");
            }
            else if (value < value_user)
            {
                Console.WriteLine("Загаданное число меньше!");
            }
            else if (value == value_user)
            {
                Console.WriteLine("Your is super puper!");
                Console.WriteLine("Game over");
                return;
            }
            if (count == 0) 
            {
                Console.WriteLine("Game over");
                return;
            }
        }
    }
}
