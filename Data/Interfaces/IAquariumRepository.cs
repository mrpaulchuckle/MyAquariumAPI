using System.Collections.Generic;

namespace MyAquariumAPI.Data
{
    public interface IAquariumRepository
    {
        IEnumerable<ITank> GetAllTanks();
        ITank GetTank(int id);
    }
}
