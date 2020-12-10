using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyAquariumAPI
{
    public interface ITank : IBaseItem
    {
        public double? CarbonDioxideLevel { get; set; }
        public double? NitrateLevel { get; set; }
        public double? Temperature { get; set; }
        public double? Salinity { get; set; }
        public bool IsFavourite { get; set; }
    }
}
