using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Podaj liczbę: ");
        int userInput = int.Parse(Console.ReadLine());
        int suma = 0;
        int max = 0;
        while (userInput != 0)
        {
            suma = suma + userInput;
            userInput = int.Parse(Console.ReadLine());
            if (userInput > max)
            {
                max = userInput;
            }
        }
        Console.WriteLine($"Suma = {suma}");
        Console.WriteLine($"Max = {max}");

    }
}
