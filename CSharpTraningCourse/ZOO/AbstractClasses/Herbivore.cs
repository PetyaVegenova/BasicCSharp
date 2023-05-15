using ZOO.Enums;

namespace ZOO.AbstractClasses
{
    public abstract class Herbivore : Animal
    {
        public Herbivore(string name) : base(name)
        {
            AnimalType = AnimalType.Herbivore;
            AvailableFoods = new List<FoodType>()
            {
                FoodType.Grass,
                FoodType.Fruits
            };
        }
    }
}
