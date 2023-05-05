using ZOO.Enums;

namespace ZOO.AbstractClasses
{
    internal abstract class Carnivore : Animal
    {
        public Carnivore(string name) : base(name)
        {
            AnimalType = AnimalType.Carnivore;
            AvailableFoods = new List<FoodType>()
            {
                FoodType.Meat
            };
        }
    }
}
