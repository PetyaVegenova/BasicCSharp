namespace _02.CheckLeapYearOrNot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int checkYear = int.Parse(Console.ReadLine());

            if ((checkYear % 4 == 0) && (checkYear % 100 != 0) || (checkYear % 400 == 0))
            {
                Console.WriteLine($"Year {checkYear} is leap year!");
            }
            else
            {
                Console.WriteLine($"Year {checkYear} is NOT leap year!");
            }
        }
    }
}