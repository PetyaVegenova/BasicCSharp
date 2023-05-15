using ZOO.Enums;

namespace ZOO.AbstractClasses
{
    public abstract class Omnivore : Animal
    {
        public Omnivore(string name) : base(name)
        {
            AnimalType = AnimalType.Omnivore;
            AvailableFoods = new List<FoodType>()
            {
                FoodType.Grass,
                FoodType.Meat,
                FoodType.Fruits
            };
        }
    }
}
