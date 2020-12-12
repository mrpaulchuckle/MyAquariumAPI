using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyAquariumAPI.Data
{
    public class SQLAquariumRepository : IAquariumRepository
    {
        private readonly IAquariumContext _Context;

        public SQLAquariumRepository(AquariumContext context)
        {
            _Context = context;
        }

        public IEnumerable<ITank> GetAllTanks() => _Context.Tanks.ToList();

        public ITank GetTank(int id) => _Context.Tanks.FirstOrDefault(x => x.ID == id);
    }
}
