using MoviesAPI.Core.Application.Dto;
using MoviesAPI.Core.Domain.Entities;


namespace MoviesAPI.Core.Application.Interfaces.Services
{
    public interface IMovieService : IGenericService<MovieDto, Movie>
    {
    }
}
