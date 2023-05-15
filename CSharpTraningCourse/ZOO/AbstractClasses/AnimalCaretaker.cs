using ZOO.Enums;

namespace ZOO.AbstractClasses
{
    public abstract class AnimalCaretaker : Worker
    {
        public AnimalCaretaker(string firstName, string lastName) : base(firstName, lastName)
        {
            Type = WorkerType.AnimalCareTaker;
        }

        public AnimalType AsignedAnimals { get; protected set; }

        public FoodType FeedAnimal()
        {
            if (this.GetType().Name == AnimalCaretakerConstats.CARNIVORES_CARETAKER)
            {
                return FoodType.Meat;
            }

            if (this.GetType().Name == AnimalCaretakerConstats.HERBIVORES_CARETAKER)
            {
                var foods = new List<FoodType>
                {
                    FoodType.Grass,
                    FoodType.Fruits
                };
                var random = new Random();
                int index = random.Next(foods.Count);

                return foods[index];
            }
                var allFoods = new List<FoodType>
                {
                    FoodType.Grass,
                    FoodType.Fruits,
                    FoodType.Meat
                };
                var allRandom = new Random();
                int allIndex = allRandom.Next(allFoods.Count);

                return allFoods[allIndex];
        }
    }
}
