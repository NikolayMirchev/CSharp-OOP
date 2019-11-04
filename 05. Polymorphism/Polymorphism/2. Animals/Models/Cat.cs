using System.Text;

namespace _2._Animals.Models
{
    public class Cat : Animal
    {
        public Cat(string name, string favouriteFood)
            : base(name, favouriteFood)
        {
        }

        public override string ExplainMyself()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ExplainMyself())
                .Append("MEEOW");
            return sb.ToString();
        }
    }
}
