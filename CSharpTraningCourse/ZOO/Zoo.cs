using ZOO.AbstractClasses;
using ZOO.Workers;

namespace ZOO
{
    internal class Zoo
    {
        public Zoo()
        {
            Animals = new List<Animal>();
            AnimalCaretakers = new List<AnimalCaretaker>();
        }

        public List<Animal> Animals { get; set; }
        public List<AnimalCaretaker> AnimalCaretakers { get; set; }
        public TicketSeller TicketSeller { get; set; }

        public void Report(int daysCount) 
        {
            for (int i = 1; i <= daysCount; i++)
            {
                DayActivities();

                Console.WriteLine($"Day {i} report");
                Console.WriteLine("---------------");
                Console.WriteLine();

                Console.WriteLine("Animals statuses:");

                for (int j = 0; j < Animals.Count; j++)
                {
                    Console.Write($"{j + 1}.");
                    Animals[j].Report();
                }

                Console.WriteLine();
                TicketSeller.Report();
                Console.WriteLine("---------------");
                Console.WriteLine();
                TicketSeller.ResetSoldTicketsCount();
            }
        }

        public void DayActivities() 
        {
            var random = new Random();
            var randomVisitorsCount = random.Next(0, 3000);

            TicketSeller.SellTickets(randomVisitorsCount);

            foreach (var animal in Animals)
            {
                var workerIndex = random.Next(0, AnimalCaretakers.Count - 1);
                var animalCareTaker = AnimalCaretakers[workerIndex];

                var food = animalCareTaker.FeedAnimal();
                animal.Eat(food);
            }
        }

        public void AddAnimals(List<Animal> animals) 
        {
            foreach (var animal in animals)
            { 
                Animals.Add(animal); 
            }
        }

        public void AddAnimalCaretakers(List<AnimalCaretaker> animalCaretakers) 
        {
            foreach (var animalCaretaker in animalCaretakers)
            {
                AnimalCaretakers.Add(animalCaretaker);
            }
        }
    }
}
