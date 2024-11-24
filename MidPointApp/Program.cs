namespace MidPointApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, welcome to my midpoint formula calculator!");
            string choice;
            do
            {
                Console.Write("Enter x1: ");
                double xOne = double.Parse(Console.ReadLine());
                Console.Write("Enter x2: ");
                double xTwo = double.Parse(Console.ReadLine());
                Console.Write("Enter y1: ");
                double yOne = double.Parse(Console.ReadLine());
                Console.Write("Enter y2: ");
                double yTwo = double.Parse(Console.ReadLine());

                double midPointX = (xOne + xTwo)/2;
                double midPointY = (yOne + yTwo)/2;

                Console.WriteLine($"Your midpoint is ({midPointX} , {midPointY})");

                Console.Write("Would you like to go again? (y/n): ");
                choice = Console.ReadLine().ToLower();
            } while (choice == "y");
        }
    }
}
