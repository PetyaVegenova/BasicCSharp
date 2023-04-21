namespace CoffeeMachine
{
    internal class CoffeeMachine : ICoffeeMachine
    {
        public CoffeeMachineType Type { get; protected set; }
        public string Make { get; private set; }
        public string Model { get; private set; }
        public int LoadedGroundedCoffeeAmount { get; protected set; }
        public int LoadedWaterAmount { get; protected set; }
        public int GroundedCoffeeTankCapacity { get; private set; }
        public int WaterTankCapacity { get; private set; }

        public CoffeeMachine(string make, string model, int waterTankCapacity, int groudedCoffeeTankCapacity)
        {
            Make = make;
            Model = model;
            WaterTankCapacity = waterTankCapacity;
            GroundedCoffeeTankCapacity = groudedCoffeeTankCapacity;
            LoadedGroundedCoffeeAmount = 0;
            LoadedWaterAmount = 0;
        }

        public void LoadGroundedCoffee(int coffeAmount)
        {
            if (LoadedGroundedCoffeeAmount + coffeAmount <= GroundedCoffeeTankCapacity)
            {
                LoadedGroundedCoffeeAmount += coffeAmount;
                Console.WriteLine($"{coffeAmount}gr of grounded coffe have been loaded");
            }
            else
            {
                Console.WriteLine($"There isn't enough space for {coffeAmount}gr of grounded coffee");
            }
        }

        public void LoadWater(int waterAmount)
        {
            if (LoadedWaterAmount + waterAmount <= WaterTankCapacity)
            {
                LoadedWaterAmount += waterAmount;
                Console.WriteLine($"{waterAmount}ml of water have been loaded");
            }
            else
            {
                Console.WriteLine($"There isn't enough space for {waterAmount}ml of water");
            }
        }

        public virtual bool MakeCoffee()
        {
            if (LoadedWaterAmount >= GlobalConstants.COFFE_DOSE_WATER_AMOUNT)
            {
                if (LoadedGroundedCoffeeAmount >= GlobalConstants.GROUNDED_COFFEE_DOSE_AMOUNT)
                {
                    Console.WriteLine(GlobalConstants.PREPARING_COFFEE_MESSAGE);
                    LoadedWaterAmount -= GlobalConstants.COFFE_DOSE_WATER_AMOUNT;
                    LoadedGroundedCoffeeAmount -= GlobalConstants.GROUNDED_COFFEE_DOSE_AMOUNT;
                    Console.WriteLine(GlobalConstants.READY_COFFEE_MESSAGE);
                    return true;
                }
                else
                {
                    Console.WriteLine(GlobalConstants.GROUNDED_COFFEE_AMOUNT_MESSAGE);
                    return false;
                }
            }
            else
            {
                Console.WriteLine(GlobalConstants.WATER_AMOUNT_MESSAGE);
                return false;
            }
        }
    }
}
