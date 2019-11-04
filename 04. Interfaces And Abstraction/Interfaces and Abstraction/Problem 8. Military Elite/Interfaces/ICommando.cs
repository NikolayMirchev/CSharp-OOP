using System;
using System.Collections.Generic;

namespace Problem_8._Military_Elite.Interfaces
{
    public interface ICommando : ISpecialisedSoldier
    {
        List<IMission> Missions { get; }
    }
}
