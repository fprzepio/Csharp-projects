using System;

class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Kalkulator BMI");
        Console.Write("Podaj swoją masę ciała [w kg]: ");
        string userWaga = Console.ReadLine();
        double waga = double.Parse(userWaga);

        Console.Write("Podaj swój wzrost [w m]: ");
        string userWzrost = Console.ReadLine();
        double wzrost = double.Parse(userWzrost);

        // Obliczanie BMI

        double BMI = waga / Math.Pow(wzrost, 2);

        Console.WriteLine("Twój wskaźnik BMI wynosi: " + BMI);

        if (BMI > 35)
        {
            Console.WriteLine("Wynik BMI to: otyłość olbrzymia");
        }
        else if (BMI >= 30 && BMI < 35)
        {
            Console.WriteLine("Wynik BMI to: otyłość");
        }
        else if (BMI >= 25 && BMI < 30)
        {
            Console.WriteLine("Wynik BMI to: nadwaga");
        }
        else if(BMI >= 18.5 && BMI < 25)
        {
            Console.WriteLine("Wynik BMI to: normalna waga");
        }
        else
        {
            Console.WriteLine("Wynik BMI to: niedowaga");
        }




    }
}
