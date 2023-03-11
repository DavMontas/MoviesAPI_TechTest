using AutoMapper;
using MoviesAPI.Core.Application.Dto;
using MoviesAPI.Core.Domain.Entities;

namespace MoviesAPI.Core.Application.Mappings
{
    public class GeneralProfile : Profile
    {
        public GeneralProfile()
        {
            #region 'mappings'

            #region 'actor'

            CreateMap<Actor, ActorDto>()
                .ReverseMap();

            #endregion


            #endregion
        }
    }
}
