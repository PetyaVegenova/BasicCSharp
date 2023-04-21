namespace CoffeeMachine
{
    internal static class GlobalConstants
    {
        public const int GROUNDED_COFFEE_DOSE_AMOUNT = 7;
        public const int BEANS_COFFEE_DOSE_AMOUNT = 11;
        public const int LATTE_DOSE_MILK_AMOUNT = 250;
        public const int CAPPUCCINO_DOSE_MILK_AMOUNT = 180;
        public const int COFFE_DOSE_WATER_AMOUNT = 50;
        public const int HOT_WATER_DOSE_AMOUNT = 220;

        // Messages constants
        public const string PREPARING_COFFEE_MESSAGE = "Preparing coffee....";
        public const string READY_COFFEE_MESSAGE = "Your coffee is ready...";
        public const string GROUNDED_COFFEE_AMOUNT_MESSAGE = "Low grounded coffee amount, please load some!";
        public const string WATER_AMOUNT_MESSAGE = "Low water amount, please load water!";
        public const string PREPARING_HOT_WATER_MESSAGE = "Preparing hot water....";
        public const string READY_HOT_WATER_MESSAGE = "Hot water is ready....";
        public const string GRINDING_COFFEE_MESSAGE = "The coffee is grinding...";
        public const string COFFEE_BEANS_AMOUNT_MESSAGE = "There isn't enough coffee beans, plese load coffee beans!";
        public const string PREPARING_CAPPUCCINO_MESSAGE = "Preparing cappuccino....";
        public const string CAPPUCCINO_IS_READY_MESSAGE = "Your cappuccino is ready...";
        public const string MILK_AMOUNT_MESSAGE = "Low milk amount, please load milk!";
        public const string PREPARING_LATTE_MESSAGE = "Preparing Latte....";
        public const string LATTE_IS_READY_MESSAGE = "Your Latte is ready...";
    }
}
