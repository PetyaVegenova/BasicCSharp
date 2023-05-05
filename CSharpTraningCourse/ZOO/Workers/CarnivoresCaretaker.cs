using ZOO.AbstractClasses;
using ZOO.Enums;

namespace ZOO.Workers
{
    internal class CarnivoresCaretaker : AnimalCaretaker
    {
        public CarnivoresCaretaker(string firstName, string lastName) : base(firstName, lastName)
        {
            AsignedAnimals = AnimalType.Carnivore;
        }
    }
}
