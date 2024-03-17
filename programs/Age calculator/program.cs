    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Insert the date of birth (dd.mm.yyyy)");

            string dateOfBirthString = Console.ReadLine();
            DateTime dateOfBirth = DateTime.Parse(dateOfBirthString);

            TimeSpan timeSpan = DateTime.Now - dateOfBirth;

            Console.WriteLine($"You were born: {Math.Round(timeSpan.TotalDays)} days ago");
        }
    }
