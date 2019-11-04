using Problem_6._Birthday_Celebrations.Interfaces;

namespace Problem_6._Birthday_Celebrations.Models
{
    public class Citizen : IId, ICitizen, IBirthdate
    {
        public Citizen(string name, int age, string id, string birthday)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.Birthday = birthday;
        }

        public string Name { get; }

        public int Age { get; }

        public string Id { get; }

        public string Birthday { get; }
    }
}
