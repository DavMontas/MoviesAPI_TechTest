using AutoMapper;
using MoviesAPI.Core.Application.Dto;
using MoviesAPI.Core.Application.Interfaces.Repositories;
using MoviesAPI.Core.Application.Interfaces.Services;
using MoviesAPI.Core.Domain.Entities;

namespace MoviesAPI.Core.Application.Services
{
    public class ActorService : GenericService<ActorDto, Actor>, IActorService
    {
        private readonly IActorRepository _repo;
        private readonly IMapper _mapper;
        public ActorService(IActorRepository repo, IMapper mapper): base(repo, mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }
    }
}
