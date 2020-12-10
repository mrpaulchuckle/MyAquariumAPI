using System.Collections.Generic;

namespace MyAquariumAPI.Data
{
    public interface IRepository
    {
        IEnumerable<ITank> GetAllTanks();
        ITank GetTank(int id);
    }
}
