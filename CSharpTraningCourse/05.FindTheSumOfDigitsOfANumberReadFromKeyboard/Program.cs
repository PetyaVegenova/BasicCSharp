namespace _05.FindTheSumOfDigitsOfANumberReadFromKeyboard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter any number:");
            var number = Console.ReadLine();
            int sum = 0;

            /* for (sum = 0; number > 0; number = number / 10)
             {
                 sum = sum + (number % 10);
             }*/

            for (int i = 0; i < number.Length; i++)
            {
                sum += int.Parse(number[i].ToString());
            }

            Console.WriteLine($"Sum of the digits is: {sum}");
        }
    }
}