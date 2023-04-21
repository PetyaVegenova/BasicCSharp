namespace _01.DivisibleBy7And11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            if (num % 7 == 0 && num % 11 == 0)
            {
                Console.WriteLine($"The number {num} is divisible by 7 and 11");
            }
            else
            {
                Console.WriteLine($"The number {num} is NOT divisible by 7 and 11");
            }
        }
    }
}