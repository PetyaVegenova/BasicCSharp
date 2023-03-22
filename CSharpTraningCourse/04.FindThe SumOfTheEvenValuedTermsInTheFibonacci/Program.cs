namespace _04.FindThe_SumOfTheEvenValuedTermsInTheFibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first = 1;
            int second = 1;
            int newTerm = 0;
            int sum = 0;

            while (newTerm <= 1000)
            {
                newTerm = first + second;

                if (newTerm % 2 == 0)
                {
                    sum += newTerm;
                }

                first = second;
                second = newTerm;
            }

            Console.WriteLine($"The sum of the even-valued terms in Fibonacci is {sum}");
        }
    }
}