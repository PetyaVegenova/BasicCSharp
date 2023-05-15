namespace Zoo.Tests
{
    public class AnimalTests
    {
        private Elephant _elephant;
        [SetUp]
        public void Setup() 
        {
            _elephant = new Elephant("Manny");
        }
        [TestCase(FoodType.Fruits)]
        [TestCase(FoodType.Grass)]
        public void Eat_AnimalIsFed_ReturnTrue(FoodType foodType) 
        {
            // act
            _elephant.Eat(foodType);

            // assert
            Assert.That(_elephant.IsFed, Is.True);
        }
        
        [Test]
        public void Eat_AnimalIsFed_ReturnFalse() 
        {
            // act 
            _elephant.Eat(FoodType.Meat);

            // assert
            Assert.That(_elephant.IsFed, Is.False);
        }

    }
}
