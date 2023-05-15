using ZOO.AbstractClasses;
using ZOO.Enums;

namespace ZOO.Workers
{
    public class HerbivoresCaretaker : AnimalCaretaker
    {
        public HerbivoresCaretaker(string firstName, string lastName) : base(firstName, lastName)
        {
            AsignedAnimals = AnimalType.Herbivore;
        }
    }
}
