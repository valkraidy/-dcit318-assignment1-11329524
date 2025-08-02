internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Triangle Type Identifier");
        Console.WriteLine("Enter the 3 sides of a triangle");
        string[] parts = Console.ReadLine().Split(' ');
        int[] sides = Array.ConvertAll(parts, int.Parse);

        int side1 = sides[0];
        int side2 = sides[1];
        int side3 = sides[2];
        Console.WriteLine($"The triangle has side1 {side1},side2 {side2} and side3 {side3}");
        if ( side1 != side2 && side1 != side3 && side2 != side3)
        {
            Console.WriteLine("Triangle is Scalene");

        }
        else if (((side1 != side2) && (side1 == side3) ) || ((side2 != side3) && (side2 == side1)) || ((side3 != side1) && (side3 == side2)))
        {
            Console.WriteLine("Triangle is Isosceles");
        }
        else if((side1 == side2 )&& (side2  ==side3))
        {
            Console.WriteLine("Triangle is Equilateral");
        }



    }
}