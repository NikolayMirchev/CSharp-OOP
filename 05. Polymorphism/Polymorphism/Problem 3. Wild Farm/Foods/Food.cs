namespace Problem_3._Wild_Farm.Foods
{
    public abstract class Food
    {
        private int quantity;

        protected Food(int quantity)
        {
            this.Quantity = quantity;
        }

        public int Quantity
        {
            get { return this.quantity; }
            set { this.quantity = value; }
        }
    }
}
