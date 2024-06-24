using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Is a Prime Number??");
        Console.WriteLine("Enter an integer number:");

        var numberTyped = Convert.ToInt32(Console.ReadLine());
        int aux = 0;

        for (int i = 1; i <= numberTyped; i++)
        {
            if (numberTyped % i == 0)
            {
                aux++;
            }
        }

        if (aux <= 2)
        {
            Console.WriteLine("It's a Prime Number!!");
        }
        else
        {
            Console.WriteLine("Isn't a Prime Number.");
        }
    }
}

