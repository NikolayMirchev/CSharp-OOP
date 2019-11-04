using System.Text;

namespace _2._Animals.Models
{
    public class Dog : Animal
    {
        public Dog(string name, string favouriteFood)
            : base(name, favouriteFood)
        {
        }

        public override string ExplainMyself()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ExplainMyself())
                .Append("DJAAF");
            return sb.ToString();
        }
    }
}
