namespace CoffeeMachine
{
    internal interface ICoffeeMachine
    {
        CoffeeMachineType Type { get; }
        string Make { get; }
        string Model { get; }
        int LoadedGroundedCoffeeAmount { get; }
        int LoadedWaterAmount { get; }
        int GroundedCoffeeTankCapacity { get; }
        int WaterTankCapacity { get; }
        void LoadGroundedCoffee(int coffeAmount);
        void LoadWater(int waterAmount);
        bool MakeCoffee();
    }
}
