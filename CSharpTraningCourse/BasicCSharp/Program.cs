namespace CoffeeMachine
{
    public class Program
    {
        static void Main(string[] args)
        {
            var mySchwarzMachine = new SchwarzMachine("Philips", "M1", 2000, 2000);
            Console.WriteLine(mySchwarzMachine);
            Console.WriteLine();
            mySchwarzMachine.LoadWater(1800);
            mySchwarzMachine.LoadGroundedCoffee(1500);
            mySchwarzMachine.MakeCoffee();
            Console.WriteLine(mySchwarzMachine.ReportAmounts());
            Console.WriteLine("----------------");

            var myEsspressoMachine = new EsspressoMachine("Delonghi", "EC685", 1500, 1800);
            Console.WriteLine(myEsspressoMachine);
            Console.WriteLine();
            myEsspressoMachine.LoadWater(500);
            myEsspressoMachine.LoadGroundedCoffee(15);
            myEsspressoMachine.MakeCoffee();
            Console.WriteLine(myEsspressoMachine.ReportAmounts());
            Console.WriteLine("----------------");

            var myAutomaticMachine = new AutomaticMachine("Krups", "EA873810", 1800, 700, 600, 900);
            Console.WriteLine(myAutomaticMachine);
            Console.WriteLine();
            myAutomaticMachine.LoadWater(1500);
            myAutomaticMachine.LoadCoffeeBeans(600);
            myAutomaticMachine.MakeDoubleCoffee();
            myAutomaticMachine.MakeLatte();
            myAutomaticMachine.LoadMilk(500);
            myAutomaticMachine.MakeCapuchino();
            myAutomaticMachine.MakeLatte();
            Console.WriteLine(myAutomaticMachine.ReportAmounts());
        }
    }
}