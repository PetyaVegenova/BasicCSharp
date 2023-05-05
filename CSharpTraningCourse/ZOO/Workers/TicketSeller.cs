using ZOO.AbstractClasses;
using ZOO.Enums;

namespace ZOO.Workers
{
    internal class TicketSeller : Worker
    {
        public TicketSeller(string firstName, string lastName) : base(firstName, lastName)
        {
            Type = WorkerType.TicketSeller;
        }

        public int SoldTicketsCount { get; private set; }

        public void SellTickets(int ticketsCount) 
        {
            if (ticketsCount > 0) 
            {
                SoldTicketsCount += ticketsCount;
            }
            else
            {
                throw new ArgumentException("Please enter a positive value for tickets count!");
            }
        }

        public void Report() 
        {
            Console.WriteLine($"Sold tickets: {SoldTicketsCount}");
        }

        public void ResetSoldTicketsCount() 
        {
            SoldTicketsCount = 0;
        }
    }
}
