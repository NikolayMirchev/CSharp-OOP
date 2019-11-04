using System;
using System.Collections.Generic;

namespace Problem_8._Military_Elite.Interfaces
{
    public interface IEngineer : ISpecialisedSoldier
    {
        List<IRepair> Repairs { get; }
    }
}
