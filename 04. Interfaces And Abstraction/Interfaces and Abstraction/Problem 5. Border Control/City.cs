using System;

namespace Problem_5._Border_Control
{
    public class City : ICitizen, IRobot, IPet
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public long Id { get; set; }
        public string Model { get; set; }
        public DateTime Birthday { get; set; }

        public City(string name, int age, long id, DateTime birthday)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.Birthday = birthday;
        }

        public City(string model, long id)
        {
            this.Model = model;
            this.Id = id;
        }

        public City(string name, DateTime birthday)
        {
            this.Name = name;
            this.Birthday = birthday;
        }


    }
}