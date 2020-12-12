using AutoMapper;
using MyAquariumAPI.DTO;

namespace MyAquariumAPI.Profiles
{
    public class BaseItemProfile : Profile
    {
        public BaseItemProfile()
        {
            CreateMap<IBaseItem, IBaseItemDTO>();
        }
    }
}
