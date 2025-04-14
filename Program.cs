using System;

public class Start
{
    public static void Main(string[] args)
    {
        int value, count = 0, high_point_user = 0, temp = 0;
        Console.Write("Введите верхнюю границу: ");
        string high_point = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(high_point))
        {
            Random rnd = new Random();
            value = rnd.Next(0, 10);
        }
        else
        {
            Random rnd = new Random();
            int.TryParse(high_point, out high_point_user);
            value = rnd.Next(0, high_point_user);
        }
        if (high_point_user != 0)
        {
            int step = 2, bases = 1;
            while (step < high_point_user)
            {
                step *= 2;
                bases++;
            }
            count = bases - 1;
        }
        else { count = 3; }
        while (count > 0) { 
            Console.Write("Введите число: ");
            int value_user = Convert.ToInt32(Console.ReadLine());
            if (value > value_user)
            {
                Console.WriteLine("Загаданное чилсо больше!");
                if (temp == value_user)
                {
                    Console.WriteLine("Введено то же число!");
                }
                else
                {
                    temp = value_user;
                    count--;
                }
            }
            else if (value < value_user)
            {
                Console.WriteLine("Загаданное число меньше!");
                if (temp == value_user)
                {
                    Console.WriteLine("Введено то же число!");
                }
                else
                {
                    temp = value_user;
                    count--;
                }
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
