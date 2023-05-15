using ZOO.AbstractClasses;
using ZOO.Animals;
using ZOO.Workers;

namespace ZOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myZoo = new Zoo();

            var animals = new List<Animal>()
            {
                new Bear("Baloo"),
                new Elephant("Manny"),
                new Goat("Gaga"),
                new Lion("Simba"),
                new Squirrel("Chip"),
                new Wolf("Akela")
            };

            myZoo.AddAnimals(animals);

            var animalCaretakers = new List<AnimalCaretaker>()
            {
                new CarnivoresCaretaker("Pesho", "Georgiev"),
                new HerbivoresCaretaker("Sasho", "Petrov"),
                new OmnivorousCaretaker("Hristo", "Hristov")
            };

            myZoo.AddAnimalCaretakers(animalCaretakers);

            var ticketSeller = new TicketSeller("Stanka", "Zlateva");

            myZoo.TicketSeller = ticketSeller;

            myZoo.Report(5);
        }
    }
}