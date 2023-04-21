namespace CoffeeMachine
{
    internal interface IAutomaticCoffeeMachine
    {
        int MilkTankCapacity { get; }
        int LoadedMilkAmount { get; }
        int CoffeeBeansTankCapacity { get; }
        int LoadedCoffeeBeansAmount { get; }
        void LoadMilk(int milkAmount);
        void MakeLatte();
        void MakeCapuchino();
        void MakeDoubleCoffee();
        void LoadCoffeeBeans(int coffeeBeansAmount);
        void GrindingCoffee();
    }
}
