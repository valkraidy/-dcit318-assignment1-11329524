internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ticket Price Calculator");
        Console.WriteLine("Enter your age");
        int age = Convert.ToInt32(Console.ReadLine());
        double dicounted_price = 7.00;
        double ticket_price = 10.00;
        try
        {

            if (age >= 65 ||  age <= 12)
            {
                Console.WriteLine("Your age is " + age);
                Console.WriteLine($"Ticket Price:{dicounted_price}");
            }
            else
            {
                Console.WriteLine("Your age is " + age);
                Console.WriteLine($"Ticket Price:{ticket_price}");
            }
        }
        catch(FormatException)
        {
            Console.WriteLine("Error: Invalid input. Please enter a valid integer");

        }
    }
}