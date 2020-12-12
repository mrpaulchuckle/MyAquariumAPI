using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyAquariumAPI.DTO
{
    public interface IBaseItemDTO
    {
        int ID { get; set; }
        string Name { get; set; }
        string Description { get; set; }
    }
}
