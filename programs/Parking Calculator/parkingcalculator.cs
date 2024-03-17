public class ParkingCalculator
{
    public static double CalculateParkingFee(int hours)
    {
        double result = 0;
        switch (hours)
        {
            case 1:
                result = 5;
                break;
            default:
                result = 5 + (--hours * 3);
                break;

        }
        return result;
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Input how many hours you've parked: ");
        int hours = int.Parse(Console.ReadLine());
        double result = CalculateParkingFee(hours);
        Console.WriteLine($"Your fee is : {result}");
    }
}
