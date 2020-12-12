using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyAquariumAPI.DTO
{
    public interface ITankDTO : IBaseItemDTO
    {
       double? CarbonDioxideLevel { get; set; }
       double? NitrateLevel { get; set; }
       double? Temperature { get; set; }
       double? Salinity { get; set; }
       bool IsFavourite { get; set; }
    }
}
