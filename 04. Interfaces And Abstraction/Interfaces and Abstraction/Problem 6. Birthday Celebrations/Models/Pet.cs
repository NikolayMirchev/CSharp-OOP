using Problem_6._Birthday_Celebrations.Interfaces;

namespace Problem_6._Birthday_Celebrations.Models
{
    public class Pet : IPet, IBirthdate
    {
        public Pet(string name, string birthday)
        {
            this.Name = name;
            this.Birthday = birthday;
        }

        public string Name { get; }

        public string Birthday { get; }
    }
}
