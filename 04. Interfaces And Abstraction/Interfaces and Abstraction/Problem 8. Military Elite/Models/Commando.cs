using Problem_8._Military_Elite.Interfaces;
using System.Collections.Generic;
using System.Text;

namespace Problem_8._Military_Elite.Models
{
    public class Commando : SpecialisedSoldier, ICommando
    {
        public Commando(int id, string firstName, string lastName, double salary, string corp, List<IMission> missions)
            : base(id, firstName, lastName, salary, corp)
        {
            this.Missions = missions;
        }

        public List<IMission> Missions { get; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString())
                .AppendLine("Missions:");
            foreach (IMission mission in Missions)
            {
                sb.AppendLine($"  {mission}");
            }
            return sb.ToString().Trim();
        }
    }
}
