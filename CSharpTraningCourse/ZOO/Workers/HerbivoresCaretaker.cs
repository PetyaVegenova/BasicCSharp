using ZOO.AbstractClasses;
using ZOO.Enums;

namespace ZOO.Workers
{
    internal class HerbivoresCaretaker : AnimalCaretaker
    {
        public HerbivoresCaretaker(string firstName, string lastName) : base(firstName, lastName)
        {
            AsignedAnimals = AnimalType.Herbivore;
        }
    }
}
