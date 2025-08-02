internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Grade Calculator");
        Console.WriteLine("Enter a numerical grade between 0 and 100");
        int numerical_grade = Convert.ToInt32(Console.ReadLine());
        try
        {
            if (numerical_grade >= 0 && numerical_grade <= 100)
            {
                Console.WriteLine("You entered a valid numerical grade " + numerical_grade);
                if (numerical_grade >= 90)
                {
                    Console.WriteLine("Letter Grade: A");
                }else if(numerical_grade >= 80)
                {
                    Console.WriteLine("Letter Grade: B");
                }else if(numerical_grade >= 70)
                {
                    Console.WriteLine("Letter Grade: C");
                }else if(numerical_grade >= 60)
                {
                    Console.WriteLine("Letter Grade: D");
                }else if(numerical_grade < 60)
                {
                    Console.WriteLine("Letter Grade: F");
                }
            }
            else
            {
                Console.WriteLine("Error: Numerical grade out of range (0-100)");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Invalid input. Enter a valid integer");
            

        }
    }
}
