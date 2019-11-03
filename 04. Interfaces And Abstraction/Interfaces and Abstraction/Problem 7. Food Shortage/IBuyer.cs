namespace Problem_7._Food_Shortage
{
    public interface IBuyer
    {
        int Food { get; set; }

        string Name { get; set; }

        int Age { get; set; }

        void BuyFood();
    }
}
