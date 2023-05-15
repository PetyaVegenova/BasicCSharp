using ZOO.AbstractClasses;
using ZOO.Enums;

namespace ZOO.Workers
{
    public class OmnivorousCaretaker : AnimalCaretaker
    {
        public OmnivorousCaretaker(string firstName, string lastName) : base(firstName, lastName)
        {
            AsignedAnimals = AnimalType.Omnivore;
        }
    }
}
