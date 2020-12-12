using AutoMapper;
using MyAquariumAPI.DTO;

namespace MyAquariumAPI.Profiles
{
    public class TanksProfile : Profile
    {
        public TanksProfile()
        {
            CreateMap<ITank, ITankDTO>().IncludeBase<IBaseItem, IBaseItemDTO>();
        }
    }
}
