namespace CoffeeMachine
{
    internal class SchwarzMachine : CoffeeMachine
    {
        public SchwarzMachine(string make, string model, int waterTankCapacity, int groudedCoffeeTankCapacity) 
            : base(make, model, waterTankCapacity, groudedCoffeeTankCapacity)
        {
            Type = CoffeeMachineType.SchwarzMachine;
        }

        public override string ToString()
        {
            return $"{Type} {Make} {Model} : " +
                $"{Environment.NewLine}- water tank capacity {WaterTankCapacity}ml " +
                $"{Environment.NewLine}- grounded coffee tank capacity {GroundedCoffeeTankCapacity}gr";
        }
    }
}
