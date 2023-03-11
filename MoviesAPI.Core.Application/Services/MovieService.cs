using AutoMapper;
using MoviesAPI.Core.Application.Dto;
using MoviesAPI.Core.Application.Interfaces.Repositories;
using MoviesAPI.Core.Application.Interfaces.Services;
using MoviesAPI.Core.Domain.Entities;


namespace MoviesAPI.Core.Application.Services
{
    public class MovieService : GenericService<MovieDto, Movie>, IMovieService
    {
        private readonly IMovieRepository _repo;
        private readonly IMapper _mapper;
        public MovieService(IMovieRepository repo, IMapper mapper): base(repo, mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }
    }
}
