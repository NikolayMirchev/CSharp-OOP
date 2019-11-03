namespace Problem_7._Food_Shortage
{
    public abstract class AbstractCitizen : IBuyer
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Food { get; set; }

        public abstract void BuyFood();
    }
}