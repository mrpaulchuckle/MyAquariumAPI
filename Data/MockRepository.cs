using MyAquariumAPI.Models;
using System.Collections.Generic;

namespace MyAquariumAPI.Data
{
    public class MockRepository : IRepository
    {
        public IEnumerable<ITank> GetAllTanks() => new List<Tank>
        {
            new Tank { ID = 1, Name = "Lounge Tank", Description = "50L tank in Lounge", Temperature = 31.0, CarbonDioxideLevel = 0.5, Salinity = 0.25, NitrateLevel = 0.7, IsFavourite = true },
            new Tank { ID = 2, Name = "Attic Tank", Description = "25L tank in Attic", Temperature = 28.0, CarbonDioxideLevel = 0.6, Salinity = 0.1, NitrateLevel = 0.2, IsFavourite = false }
        };

        public ITank GetTank(int id) => new Tank()
        {
            ID = 1,
            Name = "Lounge Tank",
            Description = "50L tank in Lounge",
            Temperature = 31.0,
            CarbonDioxideLevel = 0.5,
            Salinity = 0.25,
            NitrateLevel = 0.7,
            IsFavourite = true
        };
    }
}
