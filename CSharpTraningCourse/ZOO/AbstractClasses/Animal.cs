using ZOO.Enums;

namespace ZOO.AbstractClasses
{
    internal abstract class Animal
    {
        public Animal(string name)
        {
            Name = name;
            IsFed = false;
        }
        public string Name { get; set; }
        public AnimalType AnimalType { get; protected set; }
        public List<FoodType> AvailableFoods { get; protected set; }
        public bool IsFed { get; private set; }

        public void Eat(FoodType foodType)
        {
            if (AvailableFoods.Contains(foodType))
            {
                IsFed = true;
            }
        }

        public void Report() 
        {
            if (IsFed)
            {
                Console.WriteLine($"I am {this.GetType().Name}, my name is {Name}, and I am fed");
            }
            else
            {
                Console.WriteLine($"I am {this.GetType().Name}, my name is {Name}, and I am not fed");
            }

            IsFed = false;
        }
    }
}
