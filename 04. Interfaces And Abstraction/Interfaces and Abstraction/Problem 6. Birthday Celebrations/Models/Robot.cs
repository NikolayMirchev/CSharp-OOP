using Problem_6._Birthday_Celebrations.Interfaces;

namespace Problem_6._Birthday_Celebrations.Models
{
    public class Robot : IId, IRobot
    {
        public Robot(string model, string id)
        {
            this.Model = model;
            this.Id = id;
        }

        public string Model { get; }

        public string Id { get; }
    }
}
