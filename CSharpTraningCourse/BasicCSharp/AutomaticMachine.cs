namespace CoffeeMachine
{
    internal class AutomaticMachine : CoffeeMachine, IHotWater, IAutomaticCoffeeMachine
    {
        public int MilkTankCapacity { get; private set; }
        public int LoadedMilkAmount { get; private set; }
        public int CoffeeBeansTankCapacity { get; private set; }
        public int LoadedCoffeeBeansAmount { get; private set; }

        public AutomaticMachine(string make, string model, int waterTankCapacity, int groundedCoffeeTankCapacity, int milkTankCapacity, int coffeBeansTankCapacity)
            : base(make, model, waterTankCapacity, groundedCoffeeTankCapacity)
        {
            Type = CoffeeMachineType.AutomaticMachine;
            MilkTankCapacity = milkTankCapacity;
            CoffeeBeansTankCapacity = coffeBeansTankCapacity;
            LoadedCoffeeBeansAmount = 0;
            LoadedMilkAmount = 0;
        }

        public void GrindingCoffee()
        {
            if (LoadedCoffeeBeansAmount >= GlobalConstants.BEANS_COFFEE_DOSE_AMOUNT)
            {
                Console.WriteLine(GlobalConstants.GRINDING_COFFEE_MESSAGE);
                LoadedCoffeeBeansAmount -= GlobalConstants.BEANS_COFFEE_DOSE_AMOUNT;
                LoadedGroundedCoffeeAmount += GlobalConstants.GROUNDED_COFFEE_DOSE_AMOUNT;
            }
            else
            {
                Console.WriteLine(GlobalConstants.COFFEE_BEANS_AMOUNT_MESSAGE);
            }
        }

        public void LoadCoffeeBeans(int coffeeBeansAmount)
        {
            if (LoadedCoffeeBeansAmount + coffeeBeansAmount <= CoffeeBeansTankCapacity)
            {
                LoadedCoffeeBeansAmount += coffeeBeansAmount;
                Console.WriteLine($"{coffeeBeansAmount}gr coffee beans have been loaded");
            }
            else
            {
                Console.WriteLine($"There isn't enough space for {coffeeBeansAmount}gr of coffee beans");
            }
        }

        public void LoadMilk(int milkAmount)
        {
            if (LoadedMilkAmount + milkAmount <= MilkTankCapacity)
            {
                LoadedMilkAmount += milkAmount;
                Console.WriteLine($"{milkAmount}ml of milk have been loaded");
            }
            else
            {
                Console.WriteLine($"There isn't enough space for {milkAmount}ml of milk");
            }
        }

        public void MakeCapuchino()
        {
            if (LoadedMilkAmount >= GlobalConstants.CAPPUCCINO_DOSE_MILK_AMOUNT)
            {
                if (LoadedGroundedCoffeeAmount >= GlobalConstants.GROUNDED_COFFEE_DOSE_AMOUNT)
                {
                    Console.WriteLine(GlobalConstants.PREPARING_CAPPUCCINO_MESSAGE);
                    LoadedMilkAmount -= GlobalConstants.CAPPUCCINO_DOSE_MILK_AMOUNT;
                    var result = this.MakeCoffee();
                    if (result)
                    {
                        Console.WriteLine(GlobalConstants.CAPPUCCINO_IS_READY_MESSAGE);
                    }
                }
            }
            else
            {
                Console.WriteLine(GlobalConstants.MILK_AMOUNT_MESSAGE);
            }
        }

        public override bool MakeCoffee()
        {
            if (LoadedGroundedCoffeeAmount >= GlobalConstants.GROUNDED_COFFEE_DOSE_AMOUNT)
            {
                return base.MakeCoffee();
            }
            else
            {
                GrindingCoffee();
                return base.MakeCoffee();
            }
        }

        public void MakeDoubleCoffee()
        {
            if (this.MakeCoffee())
            {
                this.MakeCoffee();
            }
        }

        public void MakeLatte()
        {
            if (LoadedMilkAmount >= GlobalConstants.LATTE_DOSE_MILK_AMOUNT)
            {
                if (LoadedGroundedCoffeeAmount >= GlobalConstants.GROUNDED_COFFEE_DOSE_AMOUNT)
                {
                    Console.WriteLine(GlobalConstants.PREPARING_LATTE_MESSAGE);
                    LoadedMilkAmount -= GlobalConstants.LATTE_DOSE_MILK_AMOUNT;
                    var result = this.MakeCoffee();
                    if (result)
                    {
                        Console.WriteLine(GlobalConstants.LATTE_IS_READY_MESSAGE);
                    }
                }
            }
            else
            {
                Console.WriteLine(GlobalConstants.MILK_AMOUNT_MESSAGE);
            }
        }

        public void PrepareHotWater(int waterAmount)
        {
            if (LoadedWaterAmount >= GlobalConstants.HOT_WATER_DOSE_AMOUNT)
            {
                Console.WriteLine(GlobalConstants.PREPARING_HOT_WATER_MESSAGE);
                LoadedWaterAmount -= GlobalConstants.HOT_WATER_DOSE_AMOUNT;
                Console.WriteLine(GlobalConstants.READY_HOT_WATER_MESSAGE);
            }
            else
            {
                Console.WriteLine(GlobalConstants.WATER_AMOUNT_MESSAGE);
            }
        }

        public override string ToString()
        {
            return $"{Type} {Make} {Model} : " +
                $"{Environment.NewLine}- water tank capacity {WaterTankCapacity}ml " +
                $"{Environment.NewLine}- coffee beans tank capacity {CoffeeBeansTankCapacity}gr" +
                $"{Environment.NewLine}- milk tank capacity{MilkTankCapacity}ml" +
                $"{Environment.NewLine}- gounded coffee tank capacity{GroundedCoffeeTankCapacity}ml";
        }
    }
}
