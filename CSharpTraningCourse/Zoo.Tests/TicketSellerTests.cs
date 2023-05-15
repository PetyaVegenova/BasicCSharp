namespace Zoo.Tests
{
    public class TicketSellerTests
    {
        private TicketSeller _ticketSeller;
        [SetUp]
        public void Setup()
        {
            _ticketSeller = new TicketSeller("Prianka", "Chopra");
        }

        [Test]
        public void SellTickets_IncresesSoldTicketsCount()
        {

            //act
            _ticketSeller.SellTickets(3);
            _ticketSeller.SellTickets(4);

            //assert

            Assert.That(_ticketSeller.SoldTicketsCount, Is.EqualTo(7));
        }

        [Test]
        [TestCase(0)]
        [TestCase(-1)]
        public void SellTickets_TrowsExeption(int ticketsCount) 
        {
            //assert
            Assert.Throws<ArgumentException>(() => _ticketSeller.SellTickets(ticketsCount));
        }
    }
}