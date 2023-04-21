namespace CoffeeMachine
{
    internal class EsspressoMachine : CoffeeMachine, IHotWater
    {
        public EsspressoMachine(string make, string model, int waterTankCapacity, int groundedCoffeeTankCapacity) 
            : base(make, model, waterTankCapacity, groundedCoffeeTankCapacity)
        {
            Type = CoffeeMachineType.EsspressoMachine;
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
                $"{Environment.NewLine}- grounded coffee tank capacity {GroundedCoffeeTankCapacity}gr";
        }
    }
}
